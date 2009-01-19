using System.Collections.Generic;
using System.Diagnostics;

namespace StickyDesk
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> screens = Utilities.ReadSendLocationsFromFile(cAppDataFile);
            foreach (string screen in screens.Values)
            {
                string args = string.Format("\"{0}", screen);
                Process viewer = new Process();
                viewer.StartInfo.FileName = cWiiViewer;
                viewer.StartInfo.Arguments = args;
                viewer.Start();
            }
        }

        private const string cAppDataFile = "AppData.txt";

        private const string cWiiViewer = "WiiViewer.exe";
    }
}