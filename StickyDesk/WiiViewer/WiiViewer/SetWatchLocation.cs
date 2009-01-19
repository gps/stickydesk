using System;
using System.Windows.Forms;

namespace StickyDesk
{
    public partial class SetWatchLocation : Form
    {
        public SetWatchLocation()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel != fbdSendDir.ShowDialog())
            {
                txtWatchDir.Text = fbdSendDir.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtWatchDir.Text.Trim()))
            {
                MessageBox.Show("Please select Watch Directory...");
                return;
            }
            Viewer main = new Viewer(txtWatchDir.Text.Trim());
            main.Show();
            Hide();
        }
    }
}
