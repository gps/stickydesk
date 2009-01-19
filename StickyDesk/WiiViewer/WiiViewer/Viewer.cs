using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StickyDesk
{
    public partial class Viewer : Form
    {
        #region Constructors

        /// <summary>
        /// Sets the watch directory to strWatchDir.
        /// </summary>
        public Viewer(string WatchDir)
        {
            InitializeComponent();
            mFullScreen.Visible = false;
            fswImageWatcher.Path = WatchDir;
            mSendLocations = Utilities.ReadSendLocationsFromFile(Program.cAppDataFile);
            InitializeSendList();
        }

        #endregion

        #region Private Members

        /// <summary>
        /// List of picture boxes to display all thumbnails.
        /// </summary>
        private List<PictureBox> mPictureBoxes = new List<PictureBox>();

        /// <summary>
        /// Associates Picture Boxes with the Image Locations.
        /// </summary>
        private Dictionary<PictureBox, string> mImageLocations = new Dictionary<PictureBox, string>();

        private Dictionary<string, string> mSendLocations;

        /// <summary>
        /// Contains the location of the last added PicutreBox.
        /// </summary>
        private Point mLastLocation = cStartLocation;

        /// <summary>
        /// True if the current thumbnail is the first thumbnail.
        /// </summary>
        private bool mFirstThumbnail = true;

        /// <summary>
        /// Default location for first thumbnail.
        /// </summary>
        private static readonly Point cStartLocation = new Point(5,5);

        /// <summary>
        /// Default thumbnail width.
        /// </summary>
        private const int cThumbNailWidth = 200;

        /// <summary>
        /// Default thumbnail height.
        /// </summary>
        private const int cThumbNailHeight = 200;

        /// <summary>
        /// Default padding size for thumbnails.
        /// </summary>
        private const int cPadding = 5;

        #endregion

        #region Private Methods

        /// <summary>
        /// Initializes form with Send Screen data.
        /// </summary>
        private void InitializeSendList()
        {
            foreach (string screen in mSendLocations.Keys)
            {
                ToolStripMenuItem t = new ToolStripMenuItem(screen);
                tsmiSendToScreen.DropDownItems.Add(t);
            }
            tsmiSendToScreen.DropDownItemClicked += screenToolStripMenuItem_DropDownItemClicked;
        }

        /// <summary>
        /// Returns the position in which a new thumbnail should be placed.
        /// </summary>
        /// <returns>Position at which a new thumbnail should be placed.</returns>
        private Point GetNewThumbnailPosition()
        {
            if (mFirstThumbnail)
            {
                mFirstThumbnail = false;
                return mLastLocation;
            }
            if (mLastLocation.X + (2 * cThumbNailWidth) + (4 * cPadding) < mFullScreen.Width)
            {
                return mLastLocation = new Point(mLastLocation.X + cThumbNailWidth + cPadding, mLastLocation.Y);
            }
            return mLastLocation = new Point(cPadding, mLastLocation.Y + cThumbNailHeight + 3 * cPadding);
        }

        /// <summary>
        /// Removes pictureBox from this form.
        /// </summary>
        /// <param name="pictureBox">PictureBox to be removed.</param>
        private void RemovePicture(PictureBox pictureBox)
        {
            if (mPictureBoxes.Count == 0)
            {
                throw new ArgumentException("No pictures left to remove!");
            }
            mFirstThumbnail = true;
            mLastLocation = cStartLocation;
            mImageLocations.Remove(pictureBox);
            mPictureBoxes.Remove(pictureBox);
            foreach (PictureBox pb in mPictureBoxes)
            {
                pb.Location = GetNewThumbnailPosition();
            }
            Invalidate();
        }

        #endregion

        #region Events

        private void fswImageWatcher_Created(object sender, FileSystemEventArgs e)
        {
            if (mFirstThumbnail)
            {
                mFullScreen.Visible = true;
                mFullScreen.Visible = false;
            }
            PictureBox pb = new PictureBox();
            Bitmap bmp = null;
            while (bmp == null)
            {
                bmp = Utilities.GetBitmapFromFile(e.FullPath);
            }
            bmp = Utilities.ResizeBitmap(bmp, cThumbNailWidth, cThumbNailHeight);
            pb.Image = bmp;
            pb.Location = GetNewThumbnailPosition();
            pb.Size = new Size(cThumbNailWidth, cThumbNailHeight);
            pb.DoubleClick += PictureBoxes_DoubleClick;
            pb.ContextMenuStrip = cmsSendToScreen;
            mPictureBoxes.Add(pb);
            mImageLocations.Add(pb, e.FullPath);
            Controls.Add(pb);
        }

        private void pbFullScreen_DoubleClick(object sender, EventArgs e)
        {
            mFullScreen.Visible = false;
            foreach (PictureBox pb in mPictureBoxes)
            {
                pb.Visible = true;
            }
        }

        private void PictureBoxes_DoubleClick(object sender, EventArgs e)
        {
            PictureBox current = sender as PictureBox;
            string tmp = mImageLocations[current];
            mFullScreen.Image = Utilities.ResizeBitmap((Bitmap)Image.FromFile(tmp), mFullScreen.Width, mFullScreen.Height);
            foreach (PictureBox pb in mPictureBoxes)
            {
                pb.Visible = false;
            }
            mFullScreen.Visible = true;
        }

        private void Viewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void screenToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            PictureBox pb = cmsSendToScreen.SourceControl as PictureBox;
            string location = mImageLocations[pb];
            string to = mSendLocations[e.ClickedItem.ToString()];
            cmsSendToScreen.Hide();
            RemovePicture(pb);
            pb.Image.Dispose();
            pb.Dispose();
            Utilities.MoveFile(location, to);
        }

        #endregion
        
    }
}
