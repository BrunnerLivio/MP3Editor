using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic
{
    /// <summary>
    /// Represents one file
    /// </summary>
    public class File : IFile
    {
        protected string filepath;
        /// <summary>
        /// Initializes the file
        /// </summary>
        /// <param name="filepath">The path of the file</param>
        public File(string filepath)
        {
            this.filepath = filepath;
        }

        /// <summary>
        /// Returns the File path
        /// </summary>
        public string FilePath
        {
            get { return filepath; }
        }
    }
}
