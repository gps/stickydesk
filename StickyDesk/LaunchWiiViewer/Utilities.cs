using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace StickyDesk
{
    class Utilities
    {
        /// <summary>
        /// Resizes a bitmap image. Returns the same image if the new size is invalid.
        /// </summary>
        /// <param name="b">Bitmap</param>
        /// <param name="nWidth">Width of resulting image.</param>
        /// <param name="nHeight">Height of resulting image.</param>
        /// <returns>Resized bitmap image.</returns>
        public static Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            if (nWidth == 0 || nHeight == 0)
            {
                return b;
            }
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.DrawImage(b, 0, 0, nWidth, nHeight);
            }
            return result;
        }

        public static Bitmap GetBitmapFromFile(string path)
        {
            try
            {
                Bitmap bmp = new Bitmap(path);
                return bmp;
            }
            catch (ArgumentException)
            {
                return null;
            }
            catch (TargetInvocationException)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets location of where the next file should be sent.
        /// </summary>
        /// <param name="dir">Location of send directory.</param>
        /// <returns>Location of where the next file should be sent.</returns>
        public static string GetSendFileName(string dir)
        {
            DirectoryInfo sendDir = new DirectoryInfo(dir);
            FileInfo[] files = sendDir.GetFiles("*" + cImageExtension);
            if (0 == files.Length)
            {
                return dir + "1" + cImageExtension;
            }
            int lastTaken = 1;
            Array.Sort(files, new FileInfoByNumberComparer());
            foreach (FileInfo fi in files)
            {
                int tmp = 0;
                try
                {
                    tmp = int.Parse(fi.Name.Replace(cImageExtension, ""));
                }
                catch (FormatException)
                {
                }
                if (tmp - lastTaken > 1)
                {
                    lastTaken++;
                    return string.Format("{0}{1}{2}", dir, lastTaken, cImageExtension);
                }
                lastTaken = tmp;
            }
            return string.Format("{0}{1}{2}", dir, (lastTaken + 1), cImageExtension);
        }

        /// <summary>
        /// Reads Send Locations into a dictionary..
        /// </summary>
        /// <param name="AppDataFile">Location of Application Data File.</param>
        /// <returns> Dictionary with screen anme as key, and screen location as value.
        /// </returns>
        public static Dictionary<string, string> ReadSendLocationsFromFile(string AppDataFile)
        {
            Dictionary<string, string> sendLocations = new Dictionary<string, string>();
            StreamReader SR = new StreamReader(AppDataFile);
            try
            {
                int numLines = int.Parse(SR.ReadLine());
                for (int i = 0; i < numLines; ++i)
                {
                    string line = SR.ReadLine();
                    string[] split = line.Split(new[] { '|' });
                    if (2 != split.Length)
                    {
                        throw new InvalidAppDataException("Unable to split line into screen name and location.");
                    }
                    if (!split[1].EndsWith("\\"))
                    {
                        split[1] = split[1] + "\\";
                    }
                    sendLocations.Add(split[0], split[1]);
                }
                if (sendLocations.Count < 1)
                {
                    throw new InvalidAppDataException("Less than 1 send location found.");
                }
            }
            catch (FormatException ex)
            {
                throw new InvalidAppDataException(ex.Message);
            }
            catch (IOException ex)
            {
                throw new InvalidAppDataException(ex.Message);
            }
            return sendLocations;
        }

        /// <summary>
        /// Removes extension from file, and returns just the name.
        /// Here, extension is as defined by FileInfo.Extension property.
        /// </summary>
        /// <param name="file">FileInfo for which extension has to be removed.</param>
        /// <returns>Name of file without extension.</returns>
        public static string RemoveExtension(FileInfo file)
        {
            return file.Name.Remove(file.Name.LastIndexOf(file.Extension));
        }

        /// <summary>
        /// Moves file at source to dest.
        /// </summary>
        /// <param name="sourceFile">Full path to source file.</param>
        /// <param name="destDir">Full path to destination directory.</param>
        public static void MoveFile(string sourceFile, string destDir)
        {
            using (Image tmp = Image.FromFile(sourceFile))
            {
                tmp.Save(GetSendFileName(destDir), ImageFormat.Png);
            }
        }

        private const string cImageExtension = ".png";
    }
}
