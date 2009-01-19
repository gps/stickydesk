using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StickyDesk
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Writer());
            }
            catch (InvalidAppDataException ex)
            {
                string errMsg = "App data file was found to be invalid.";
                errMsg += "Please fix this issue and restart the application.";
                errMsg += Environment.NewLine + Environment.NewLine;
                errMsg += "Message to developer:" + Environment.NewLine;
                errMsg += ex.Message;
                MessageBox.Show(errMsg, "Fatal Error!", MessageBoxButtons.OK);
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
