using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic
{
    /// <summary>
    /// Strategy to read file
    /// </summary>
    public interface IFileTypeReader
    {
        /// <summary>
        /// Reads data from a file
        /// </summary>
        /// <param name="filepath">The path of the file, which should get read</param>
        /// <returns></returns>
        IFile Read(string filepath);
    }
}
