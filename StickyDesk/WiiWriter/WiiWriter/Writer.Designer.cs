namespace StickyDesk
{
    partial class Writer
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
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.cmbSend = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbDraw = new System.Windows.Forms.GroupBox();
            this.gbCurrentColor = new System.Windows.Forms.GroupBox();
            this.txtCurrentBackground = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.txtCurrentColor = new System.Windows.Forms.TextBox();
            this.gbBackground = new System.Windows.Forms.GroupBox();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.cmbBackground = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnBlack = new System.Windows.Forms.RadioButton();
            this.rbtnGray = new System.Windows.Forms.RadioButton();
            this.btnForegroundColor = new System.Windows.Forms.Button();
            this.rbtnMagenta = new System.Windows.Forms.RadioButton();
            this.rbtnYellow = new System.Windows.Forms.RadioButton();
            this.rbtnOrange = new System.Windows.Forms.RadioButton();
            this.rbtnLime = new System.Windows.Forms.RadioButton();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.rbEraser = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.cdMoreColors = new System.Windows.Forms.ColorDialog();
            this.pbDrawArea = new System.Windows.Forms.PictureBox();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.gbActions.SuspendLayout();
            this.gbDraw.SuspendLayout();
            this.gbCurrentColor.SuspendLayout();
            this.gbBackground.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawArea)).BeginInit();
            this.SuspendLayout();
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.cmbSend);
            this.gbActions.Controls.Add(this.btnLoad);
            this.gbActions.Controls.Add(this.btnSave);
            this.gbActions.Controls.Add(this.btnSend);
            this.gbActions.Controls.Add(this.btnClear);
            this.gbActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbActions.Location = new System.Drawing.Point(0, 0);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(1008, 63);
            this.gbActions.TabIndex = 0;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // cmbSend
            // 
            this.cmbSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSend.FormattingEnabled = true;
            this.cmbSend.Location = new System.Drawing.Point(250, 22);
            this.cmbSend.Name = "cmbSend";
            this.cmbSend.Size = new System.Drawing.Size(121, 21);
            this.cmbSend.Sorted = true;
            this.cmbSend.TabIndex = 4;
            this.cmbSend.SelectedIndexChanged += new System.EventHandler(this.cmbSend_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(169, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(377, 20);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbDraw
            // 
            this.gbDraw.Controls.Add(this.gbCurrentColor);
            this.gbDraw.Controls.Add(this.gbBackground);
            this.gbDraw.Controls.Add(this.groupBox1);
            this.gbDraw.Controls.Add(this.rbEraser);
            this.gbDraw.Controls.Add(this.rbPen);
            this.gbDraw.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDraw.Location = new System.Drawing.Point(0, 63);
            this.gbDraw.Name = "gbDraw";
            this.gbDraw.Size = new System.Drawing.Size(102, 669);
            this.gbDraw.TabIndex = 1;
            this.gbDraw.TabStop = false;
            this.gbDraw.Text = "Draw";
            // 
            // gbCurrentColor
            // 
            this.gbCurrentColor.Controls.Add(this.txtCurrentBackground);
            this.gbCurrentColor.Controls.Add(this.lblSeparator);
            this.gbCurrentColor.Controls.Add(this.txtCurrentColor);
            this.gbCurrentColor.Location = new System.Drawing.Point(6, 402);
            this.gbCurrentColor.Name = "gbCurrentColor";
            this.gbCurrentColor.Size = new System.Drawing.Size(89, 65);
            this.gbCurrentColor.TabIndex = 13;
            this.gbCurrentColor.TabStop = false;
            this.gbCurrentColor.Text = "Current Color";
            // 
            // txtCurrentBackground
            // 
            this.txtCurrentBackground.BackColor = System.Drawing.Color.White;
            this.txtCurrentBackground.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrentBackground.ForeColor = System.Drawing.Color.White;
            this.txtCurrentBackground.Location = new System.Drawing.Point(59, 28);
            this.txtCurrentBackground.Name = "txtCurrentBackground";
            this.txtCurrentBackground.ReadOnly = true;
            this.txtCurrentBackground.Size = new System.Drawing.Size(21, 20);
            this.txtCurrentBackground.TabIndex = 12;
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(34, 31);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(19, 13);
            this.lblSeparator.TabIndex = 11;
            this.lblSeparator.Text = "on";
            // 
            // txtCurrentColor
            // 
            this.txtCurrentColor.BackColor = System.Drawing.Color.Black;
            this.txtCurrentColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrentColor.ForeColor = System.Drawing.Color.Black;
            this.txtCurrentColor.Location = new System.Drawing.Point(7, 28);
            this.txtCurrentColor.Name = "txtCurrentColor";
            this.txtCurrentColor.ReadOnly = true;
            this.txtCurrentColor.Size = new System.Drawing.Size(21, 20);
            this.txtCurrentColor.TabIndex = 10;
            // 
            // gbBackground
            // 
            this.gbBackground.Controls.Add(this.btnBackgroundColor);
            this.gbBackground.Controls.Add(this.cmbBackground);
            this.gbBackground.Location = new System.Drawing.Point(7, 67);
            this.gbBackground.Name = "gbBackground";
            this.gbBackground.Size = new System.Drawing.Size(89, 82);
            this.gbBackground.TabIndex = 12;
            this.gbBackground.TabStop = false;
            this.gbBackground.Text = "Background";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(5, 46);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(75, 23);
            this.btnBackgroundColor.TabIndex = 7;
            this.btnBackgroundColor.Text = "More";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // cmbBackground
            // 
            this.cmbBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackground.FormattingEnabled = true;
            this.cmbBackground.Items.AddRange(new object[] {
            "Custom",
            "White",
            "Yellow",
            "Lime",
            "Orange",
            "Magenta",
            "Red",
            "Blue",
            "Black",
            "Gray"});
            this.cmbBackground.Location = new System.Drawing.Point(6, 19);
            this.cmbBackground.Name = "cmbBackground";
            this.cmbBackground.Size = new System.Drawing.Size(76, 21);
            this.cmbBackground.TabIndex = 0;
            this.cmbBackground.SelectedIndexChanged += new System.EventHandler(this.cmbBackground_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnBlack);
            this.groupBox1.Controls.Add(this.rbtnGray);
            this.groupBox1.Controls.Add(this.btnForegroundColor);
            this.groupBox1.Controls.Add(this.rbtnMagenta);
            this.groupBox1.Controls.Add(this.rbtnYellow);
            this.groupBox1.Controls.Add(this.rbtnOrange);
            this.groupBox1.Controls.Add(this.rbtnLime);
            this.groupBox1.Controls.Add(this.rbtnRed);
            this.groupBox1.Controls.Add(this.rbtnBlue);
            this.groupBox1.Location = new System.Drawing.Point(6, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 241);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pen Color";
            // 
            // rbtnBlack
            // 
            this.rbtnBlack.AutoSize = true;
            this.rbtnBlack.Checked = true;
            this.rbtnBlack.Location = new System.Drawing.Point(8, 185);
            this.rbtnBlack.Name = "rbtnBlack";
            this.rbtnBlack.Size = new System.Drawing.Size(52, 17);
            this.rbtnBlack.TabIndex = 7;
            this.rbtnBlack.TabStop = true;
            this.rbtnBlack.Text = "Black";
            this.rbtnBlack.UseVisualStyleBackColor = true;
            this.rbtnBlack.CheckedChanged += new System.EventHandler(this.rbtnPenColor_CheckedChanged);
            // 
            // rbtnGray
            // 
            this.rbtnGray.AutoSize = true;
            this.rbtnGray.ForeColor = System.Drawing.Color.Gray;
            this.rbtnGray.Location = new System.Drawing.Point(8, 162);
            this.rbtnGray.Name = "rbtnGray";
            this.rbtnGray.Size = new System.Drawing.Size(47, 17);
            this.rbtnGray.TabIndex = 6;
            this.rbtnGray.Text = "Gray";
            this.rbtnGray.UseVisualStyleBackColor = true;
            this.rbtnGray.CheckedChanged += new System.EventHandler(this.rbtnPenColor_CheckedChanged);
            // 
            // btnForegroundColor
            // 
            this.btnForegroundColor.Location = new System.Drawing.Point(8, 208);
            this.btnForegroundColor.Name = "btnForegroundColor";
            this.btnForegroundColor.Size = new System.Drawing.Size(75, 23);
            this.btnForegroundColor.TabIndex = 6;
            this.btnForegroundColor.Text = "More";
            this.btnForegroundColor.UseVisualStyleBackColor = true;
            this.btnForegroundColor.Click += new System.EventHandler(this.btnForegroundColor_Click);
            // 
            // rbtnMagenta
            // 
            this.rbtnMagenta.AutoSize = true;
            this.rbtnMagenta.ForeColor = System.Drawing.Color.Magenta;
            this.rbtnMagenta.Location = new System.Drawing.Point(8, 139);
            this.rbtnMagenta.Name = "rbtnMagenta";
            this.rbtnMagenta.Size = new System.Drawing.Size(67, 17);
            this.rbtnMagenta.TabIndex = 5;
            this.rbtnMagenta.Text = "Magenta";
            this.rbtnMagenta.UseVisualStyleBackColor = true;
            this.rbtnMagenta.CheckedChanged += new System.EventHandler(this.rbtnPenColor_CheckedChanged);
            // 
            // rbtnYellow
            // 
            this.rbtnYellow.AutoSize = true;
            this.rbtnYellow.ForeColor = System.Drawing.Color.Yellow;
            this.rbtnYellow.Location = new System.Drawing.Point(8, 116);
            this.rbtnYellow.Name = "rbtnYellow";
            this.rbtnYellow.Size = new System.Drawing.Size(56, 17);
            this.rbtnYellow.TabIndex = 4;
            this.rbtnYellow.Text = "Yellow";
            this.rbtnYellow.UseVisualStyleBackColor = true;
            this.rbtnYellow.CheckedChanged += new System.EventHandler(this.rbtnPenColor_CheckedChanged);
            // 
            // rbtnOrange
            // 
            this.rbtnOrange.AutoSize = true;
            this.rbtnOrange.ForeColor = System.Drawing.Color.Orange;
            this.rbtnOrange.Location = new System.Drawing.Point(8, 93);
            this.rbtnOrange.Name = "rbtnOrange";
            this.rbtnOrange.Size = new System.Drawing.Size(60, 17);
            this.rbtnOrange.TabIndex = 3;
            this.rbtnOrange.Text = "Orange";
            this.rbtnOrange.UseVisualStyleBackColor = true;
            this.rbtnOrange.CheckedChanged += new System.EventHandler(this.rbtnPenColor_CheckedChanged);
            // 
            // rbtnLime
            // 
            this.rbtnLime.AutoSize = true;
            this.rbtnLime.ForeColor = System.Drawing.Color.Lime;
            this.rbtnLime.Location = new System.Drawing.Point(8, 67);
            this.rbtnLime.Name = "rbtnLime";
            this.rbtnLime.Size = new System.Drawing.Size(47, 17);
            this.rbtnLime.TabIndex = 2;
            this.rbtnLime.Text = "Lime";
            this.rbtnLime.UseVisualStyleBackColor = true;
            this.rbtnLime.CheckedChanged += new System.EventHandler(this.rbtnPenColor_CheckedChanged);
            // 
            // rbtnRed
            // 
            this.rbtnRed.AutoSize = true;
            this.rbtnRed.ForeColor = System.Drawing.Color.Red;
            this.rbtnRed.Location = new System.Drawing.Point(8, 44);
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.Size = new System.Drawing.Size(45, 17);
            this.rbtnRed.TabIndex = 1;
            this.rbtnRed.Text = "Red";
            this.rbtnRed.UseVisualStyleBackColor = true;
            this.rbtnRed.CheckedChanged += new System.EventHandler(this.rbtnPenColor_CheckedChanged);
            // 
            // rbtnBlue
            // 
            this.rbtnBlue.AutoSize = true;
            this.rbtnBlue.ForeColor = System.Drawing.Color.Blue;
            this.rbtnBlue.Location = new System.Drawing.Point(8, 21);
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.Size = new System.Drawing.Size(46, 17);
            this.rbtnBlue.TabIndex = 0;
            this.rbtnBlue.Text = "Blue";
            this.rbtnBlue.UseVisualStyleBackColor = true;
            this.rbtnBlue.CheckedChanged += new System.EventHandler(this.rbtnPenColor_CheckedChanged);
            // 
            // rbEraser
            // 
            this.rbEraser.AutoSize = true;
            this.rbEraser.Location = new System.Drawing.Point(7, 44);
            this.rbEraser.Name = "rbEraser";
            this.rbEraser.Size = new System.Drawing.Size(55, 17);
            this.rbEraser.TabIndex = 8;
            this.rbEraser.TabStop = true;
            this.rbEraser.Text = "Eraser";
            this.rbEraser.UseVisualStyleBackColor = true;
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Location = new System.Drawing.Point(6, 20);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(44, 17);
            this.rbPen.TabIndex = 7;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            this.rbPen.CheckedChanged += new System.EventHandler(this.rbPen_CheckedChanged);
            // 
            // pbDrawArea
            // 
            this.pbDrawArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDrawArea.Location = new System.Drawing.Point(102, 63);
            this.pbDrawArea.Name = "pbDrawArea";
            this.pbDrawArea.Size = new System.Drawing.Size(906, 669);
            this.pbDrawArea.TabIndex = 2;
            this.pbDrawArea.TabStop = false;
            this.pbDrawArea.MouseLeave += new System.EventHandler(this.pbDrawArea_MouseLeave);
            this.pbDrawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDrawArea_MouseMove);
            this.pbDrawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDrawArea_MouseDown);
            this.pbDrawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDrawArea_MouseUp);
            this.pbDrawArea.MouseEnter += new System.EventHandler(this.pbDrawArea_MouseEnter);
            // 
            // sfdSave
            // 
            this.sfdSave.AddExtension = false;
            this.sfdSave.DefaultExt = "(Image - Portable Network Graphics)|*.png";
            this.sfdSave.Filter = "(Image - Portable Network Graphics)|*.png";
            this.sfdSave.Title = "Save Image To...";
            // 
            // ofdLoad
            // 
            this.ofdLoad.DefaultExt = "(Image - Portable Network Graphics)|*.png";
            this.ofdLoad.Filter = "(Image - Portable Network Graphics)|*.png|(Bitmap)|*.bmp|(JPEG)|*.jpeg;*.jpg|(All" +
                " Files)|*.*";
            // 
            // Writer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 732);
            this.Controls.Add(this.pbDrawArea);
            this.Controls.Add(this.gbDraw);
            this.Controls.Add(this.gbActions);
            this.Name = "Writer";
            this.Text = "Wiimote Writer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Writer_Paint);
            this.SizeChanged += new System.EventHandler(this.Writer_ResizeEnd);
            this.Resize += new System.EventHandler(this.Writer_Resize);
            this.ResizeEnd += new System.EventHandler(this.Writer_ResizeEnd);
            this.gbActions.ResumeLayout(false);
            this.gbDraw.ResumeLayout(false);
            this.gbDraw.PerformLayout();
            this.gbCurrentColor.ResumeLayout(false);
            this.gbCurrentColor.PerformLayout();
            this.gbBackground.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.GroupBox gbDraw;
        private System.Windows.Forms.ColorDialog cdMoreColors;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnForegroundColor;
        private System.Windows.Forms.PictureBox pbDrawArea;
        private System.Windows.Forms.RadioButton rbEraser;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.TextBox txtCurrentColor;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnRed;
        private System.Windows.Forms.RadioButton rbtnBlue;
        private System.Windows.Forms.RadioButton rbtnBlack;
        private System.Windows.Forms.RadioButton rbtnGray;
        private System.Windows.Forms.RadioButton rbtnMagenta;
        private System.Windows.Forms.RadioButton rbtnYellow;
        private System.Windows.Forms.RadioButton rbtnOrange;
        private System.Windows.Forms.RadioButton rbtnLime;
        private System.Windows.Forms.ComboBox cmbSend;
        private System.Windows.Forms.GroupBox gbBackground;
        private System.Windows.Forms.ComboBox cmbBackground;
        private System.Windows.Forms.TextBox txtCurrentBackground;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.GroupBox gbCurrentColor;
        private System.Windows.Forms.Button btnBackgroundColor;
    }
}

