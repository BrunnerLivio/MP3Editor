using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic
{
    /// <summary>
    /// Strategy to write to file
    /// </summary>
    public interface IFileTypeWriter
    {
        /// <summary>
        /// The file which should get written on
        /// </summary>
        /// <param name="file">The file which should get written on</param>
        void Write(IFile file);
    }
}
