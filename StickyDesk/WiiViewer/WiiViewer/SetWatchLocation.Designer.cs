namespace StickyDesk
{
    partial class SetWatchLocation
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtWatchDir = new System.Windows.Forms.TextBox();
            this.lblSendDir = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.fbdSendDir = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(147, 165);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtWatchDir
            // 
            this.txtWatchDir.Location = new System.Drawing.Point(105, 77);
            this.txtWatchDir.Name = "txtWatchDir";
            this.txtWatchDir.Size = new System.Drawing.Size(271, 20);
            this.txtWatchDir.TabIndex = 6;
            // 
            // lblSendDir
            // 
            this.lblSendDir.AutoSize = true;
            this.lblSendDir.Location = new System.Drawing.Point(15, 80);
            this.lblSendDir.Name = "lblSendDir";
            this.lblSendDir.Size = new System.Drawing.Size(84, 13);
            this.lblSendDir.TabIndex = 5;
            this.lblSendDir.Text = "Watch Directory";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(295, 103);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // SetWatchLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 264);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtWatchDir);
            this.Controls.Add(this.lblSendDir);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SetWatchLocation";
            this.Text = "Set Watch Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtWatchDir;
        private System.Windows.Forms.Label lblSendDir;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.FolderBrowserDialog fbdSendDir;
    }
}