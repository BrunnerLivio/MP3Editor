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
    public abstract class File : IFile
    {
        protected TagLib.Tag tag;
        protected string filepath;
        /// <summary>
        /// Initializes the file
        /// </summary>
        /// <param name="tag">The tags to read from</param>
        /// <param name="filepath">The path of the file</param>
        protected File(TagLib.Tag tag, string filepath)
        {
            this.tag = tag;
            this.filepath = filepath;
        }

        /// <summary>
        /// Returns the tags of the file
        /// </summary>
        public TagLib.Tag Tag
        {
            get
            {
                return tag;
            }
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
