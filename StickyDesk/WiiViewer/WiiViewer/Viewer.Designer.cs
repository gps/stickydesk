namespace StickyDesk
{
    partial class Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fswImageWatcher = new System.IO.FileSystemWatcher();
            this.mFullScreen = new System.Windows.Forms.PictureBox();
            this.cmsSendToScreen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSendToScreen = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fswImageWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFullScreen)).BeginInit();
            this.cmsSendToScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // fswImageWatcher
            // 
            this.fswImageWatcher.EnableRaisingEvents = true;
            this.fswImageWatcher.Filter = "*.png";
            this.fswImageWatcher.SynchronizingObject = this;
            this.fswImageWatcher.Created += new System.IO.FileSystemEventHandler(this.fswImageWatcher_Created);
            // 
            // mFullScreen
            // 
            this.mFullScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mFullScreen.Location = new System.Drawing.Point(0, 0);
            this.mFullScreen.Name = "mFullScreen";
            this.mFullScreen.Size = new System.Drawing.Size(1008, 732);
            this.mFullScreen.TabIndex = 0;
            this.mFullScreen.TabStop = false;
            this.mFullScreen.DoubleClick += new System.EventHandler(this.pbFullScreen_DoubleClick);
            // 
            // cmsSendToScreen
            // 
            this.cmsSendToScreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSendToScreen});
            this.cmsSendToScreen.Name = "cmsSendToScreen";
            this.cmsSendToScreen.Size = new System.Drawing.Size(171, 26);
            // 
            // tsmiSendToScreen
            // 
            this.tsmiSendToScreen.Name = "tsmiSendToScreen";
            this.tsmiSendToScreen.Size = new System.Drawing.Size(170, 22);
            this.tsmiSendToScreen.Text = "Send to Screen...";
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 732);
            this.Controls.Add(this.mFullScreen);
            this.Name = "Viewer";
            this.Text = "Sticky Desk Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Viewer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.fswImageWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFullScreen)).EndInit();
            this.cmsSendToScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fswImageWatcher;
        private System.Windows.Forms.PictureBox mFullScreen;
        private System.Windows.Forms.ContextMenuStrip cmsSendToScreen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendToScreen;
    }
}

