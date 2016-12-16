using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic
{
    /// <summary>
    /// Interface for a writer strategy
    /// </summary>
    public interface IFileTypeWriter
    {
        /// <summary>
        /// Writes the data to the given file
        /// </summary>
        /// <param name="file">The file to write the data on</param>
        void Write(IFile file);
    }
}
