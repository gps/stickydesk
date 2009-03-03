using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace StickyDesk
{
    /// <summary>
    /// Writer form
    /// </summary>
    public partial class Writer : Form
    {
        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Writer()
        {
            InitializeComponent();
            mDrawArea = new Bitmap(pbDrawArea.Width, pbDrawArea.Height, PixelFormat.Format24bppRgb);
            using (Graphics tmp = Graphics.FromImage(mDrawArea))
            {
                tmp.Clear(mBackground);
                pbDrawArea.Image = mDrawArea;
            }
            rbPen.Select();
            cmbBackground.SelectedIndex = 1;
            mSendLocations = Utilities.ReadSendLocationsFromFile(cAppDataFile);
            InitializeSendList();
        }

        #endregion

        #region Private Members

        /// <summary>
        /// True if mouse is clicked down. False otherwise.
        /// </summary>
        private bool mMouseDown = false;

        /// <summary>
        /// True if pen is down. False otherwise.
        /// </summary>
        private bool mPenDown = false;

        /// <summary>
        /// True if eraser is down. False otherwise.
        /// </summary>
        private bool mEraserDown = false;

        /// <summary>
        /// Draw Area Image.
        /// </summary>
        private Bitmap mDrawArea;

        /// <summary>
        /// Start X co-ordinate of mouse.
        /// </summary>
        private int mMouseX;

        /// <summary>
        /// Start Y co-ordinate of mouse.
        /// </summary>
        private int mMouseY;

        /// <summary>
        /// Current color of pen.
        /// </summary>
        private Color mForeground = Color.Black;

        /// <summary>
        /// Current background color.
        /// </summary>
        private Color mBackground = Color.White;

        /// <summary>
        /// Location to send image to.
        /// </summary>
        private string mCurSendLocation;

        /// <summary>
        /// Stores Send Locations.
        /// Key is screen name, and Value is screen's send location.
        /// </summary>
        private Dictionary<string, string> mSendLocations;

        /// <summary>
        /// Location of app data file.
        /// </summary>
        private const string cAppDataFile = "AppData.txt";

        /// <summary>
        /// Width of writing pen.
        /// </summary>
        private const float cPenWidth = 5.0F;

        #endregion

        #region Private Methods

        /// <summary>
        /// Initializes cmbSend with items in htSendLocations.
        /// Sets strCurSendLocation to first item in cmbSend.
        /// </summary>
        private void InitializeSendList()
        {
            foreach (string screen in mSendLocations.Keys)
            {
                cmbSend.Items.Add(screen);
            }
            cmbSend.SelectedIndex = 0;
            mCurSendLocation = mSendLocations[(string)cmbSend.Items[0]];
        }

        #endregion

        #region Events

        private void Writer_Paint(object sender, PaintEventArgs e)
        {
            pbDrawArea.Image = mDrawArea;
        }

        private void Writer_Resize(object sender, EventArgs e)
        {
            using (Graphics tmp = Graphics.FromImage(mDrawArea))
            {
                tmp.DrawImage(mDrawArea, 0, 0, pbDrawArea.Width, pbDrawArea.Height);
                Invalidate();
            }
        }

        private void Writer_ResizeEnd(object sender, EventArgs e)
        {
            mDrawArea = Utilities.ResizeBitmap(mDrawArea, pbDrawArea.Width, pbDrawArea.Height);
            Invalidate();
        }

        private void pbDrawArea_MouseDown(object sender, MouseEventArgs e)
        {
            mMouseDown = true;
            mMouseX = e.X;
            mMouseY = e.Y;
        }

        private void pbDrawArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (mMouseDown)
            {
                if (mPenDown)
                {
                    using (Graphics graphics = Graphics.FromImage(mDrawArea))
                    {
                        using (Pen pen = new Pen(mForeground))
                        {
                            pen.Width = cPenWidth;
                            graphics.DrawLine(pen, mMouseX, mMouseY, e.X, e.Y);
                        }
                    }
                    mMouseX = e.X;
                    mMouseY = e.Y;
                    Invalidate();
                }
                else if (mEraserDown)
                {
                    using (Graphics graphics = Graphics.FromImage(mDrawArea))
                    {
                        using (Brush brush = new SolidBrush(mBackground))
                        {
                            graphics.CompositingMode = CompositingMode.SourceCopy;
                            graphics.FillEllipse(brush, e.X - 10, e.Y - 10, 20, 20);
                        }
                    }
                    mMouseX = e.X;
                    mMouseY = e.Y;
                    Invalidate();
                }
            }
        }

        private void pbDrawArea_MouseUp(object sender, MouseEventArgs e)
        {
            mMouseDown = false;
        }

        private void pbDrawArea_MouseEnter(object sender, EventArgs e)
        {
            if (mEraserDown)
            {
                Cursor = Cursors.Hand;
            }
        }

        private void pbDrawArea_MouseLeave(object sender, EventArgs e)
        {
            if (mEraserDown)
            {
                Cursor = Cursors.Default;
            }
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPen.Checked)
            {
                mPenDown = true;
                mEraserDown = false;
                Cursor = Cursors.Default;
            }
            else
            {
                mEraserDown = true;
                mPenDown = false;
            }
        }

        private void rbtnPenColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;
            if (rbtn.Checked)
            {
                mForeground = rbtn.ForeColor;
                txtCurrentColor.BackColor = mForeground;
            }
        }

        private void btnForegroundColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel != cdMoreColors.ShowDialog())
            {
                mForeground = cdMoreColors.Color;
                txtCurrentColor.BackColor = cdMoreColors.Color;
                rbtnBlack.Checked = false;
                rbtnGray.Checked = false;
                rbtnMagenta.Checked = false;
                rbtnYellow.Checked = false;
                rbtnOrange.Checked = false;
                rbtnLime.Checked = false;
                rbtnRed.Checked = false;
                rbtnBlue.Checked = false;
            }
        }

        private void cmbBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBackground.SelectedIndex)
            {
                case 0: // Custom
                    {
                        return;
                    }
                case 1: // White
                    {
                        mBackground = Color.White;
                        break;
                    }
                case 2: // Yellow
                    {
                        mBackground = Color.Yellow;
                        break;
                    }
                case 3: // Lime
                    {
                        mBackground = Color.Lime;
                        break;
                    }
                case 4: // Orange
                    {
                        mBackground = Color.Orange;
                        break;
                    }
                case 5: // Magenta
                    {
                        mBackground = Color.Magenta;
                        break;
                    }
                case 6: // Red
                    {
                        mBackground = Color.Red;
                        break;
                    }
                case 7: // Blue
                    {
                        mBackground = Color.Blue;
                        break;
                    }
                case 8: // Black
                    {
                        mBackground = Color.Black;
                        break;
                    }
                case 9: // Gray
                    {
                        mBackground = Color.Gray;
                        break;
                    }
                default: // Reset to white.
                    {
                        cmbBackground.SelectedIndex = 1;
                        return;
                    }
            }
            txtCurrentBackground.BackColor = mBackground;
            btnClear_Click(null, null);
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel != cdMoreColors.ShowDialog())
            {
                mBackground = cdMoreColors.Color;
                txtCurrentBackground.BackColor = mBackground;
                cmbBackground.SelectedIndex = 0;
                btnClear_Click(null, null);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            using (Graphics tmp = Graphics.FromImage(mDrawArea))
            {
                tmp.Clear(mBackground);
                Invalidate();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel != sfdSave.ShowDialog())
            {
                mDrawArea.Save(sfdSave.FileName, ImageFormat.Png);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel != ofdLoad.ShowDialog())
            {
                using (Bitmap bmp = Utilities.ResizeBitmap(new Bitmap(ofdLoad.FileName), 
                    pbDrawArea.Width, pbDrawArea.Height))
                {
                    using (Graphics graphics = Graphics.FromImage(mDrawArea))
                    {
                        graphics.Clear(Color.White);
                        graphics.DrawImage(bmp, 0, 0);
                        Invalidate();
                    }
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            pbDrawArea.Image.Save(Utilities.GetSendFileName(mCurSendLocation), ImageFormat.Png);
        }

        private void cmbSend_SelectedIndexChanged(object sender, EventArgs e)
        {
            mCurSendLocation = mSendLocations[(string)cmbSend.Items[cmbSend.SelectedIndex]];
        }

        #endregion
    }
}
