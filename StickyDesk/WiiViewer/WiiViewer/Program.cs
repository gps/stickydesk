using System;
using System.Windows.Forms;

namespace StickyDesk
{
    static class Program
    {
        public const string cAppDataFile = "AppData.txt";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (args.Length == 0)
                {
                    Application.Run(new SetWatchLocation());
                }
                else if (args.Length == 1)
                {
                    Application.Run(new Viewer(args[0]));
                }
                else
                {
                    MessageBox.Show("Invalid launch arguments. Program terminating!", "Fatal Error!", 
                        MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                string errMsg = "Program encountered an unexpected error. Program terminating...";
                errMsg += Environment.NewLine;
                errMsg += "Message to developer:" + Environment.NewLine;
                errMsg += ex.Message;
                MessageBox.Show(errMsg, "Fatal Error!", MessageBoxButtons.OK);
            }
        }
    }
}
