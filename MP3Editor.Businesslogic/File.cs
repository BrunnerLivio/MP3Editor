using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic
{
    /// <summary>
    /// Represents one file
    /// </summary>
    public abstract class File : IFile
    {
        protected TagLib.File file;
        /// <summary>
        /// Initializes the file
        /// </summary>
        /// <param name="file">The file to read from</param>
        protected File(TagLib.File file)
        {
            this.file = file;
        }

        /// <summary>
        /// Write the data to the file
        /// </summary>
        public abstract void Save();
    }
}
