using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic
{
    /// <summary>
    /// Interface for File Type Reader
    /// </summary>
    public interface IFileTypeReader
    {
        /// <summary>
        /// Reads the Filetype
        /// </summary>
        /// <param name="filepath">The absolute path of the file</param>
        /// <returns>The file</returns>
        IFile Read(string filepath);
    }
}
