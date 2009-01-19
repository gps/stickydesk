using System;
using System.Collections.Generic;
using System.IO;

namespace StickyDesk
{
    public class FileInfoByNumberComparer : IComparer<FileInfo>
    {
        #region IComparer<FileInfo> Members

        /// <summary>
        /// Implementation of IComparer's Compare method.
        /// Gets numbers out of x and y's filenames (by removing extension)
        /// and compares the numbers.
        /// </summary>
        /// <param name="x">LHS.</param>
        /// <param name="y">RHS.</param>
        /// <returns>1 if LHS > RHS; 0 if LHS == RHS. -1 otherwise.</returns>
        public int Compare(FileInfo x, FileInfo y)
        {
            try
            {
                int a = int.Parse(Utilities.RemoveExtension(x));
                int b = int.Parse(Utilities.RemoveExtension(y));
                if (a < b)
                {
                    return -1;
                }
                if (a > b)
                {
                    return 1;
                }
                if (a == b)
                {
                    return 0;
                }
            }
            catch (FormatException)
            {
                return x.Name.CompareTo(y.Name);
            }
            throw new FormatException("Filenames cannot be compared!");
        }

        #endregion
    }
}
