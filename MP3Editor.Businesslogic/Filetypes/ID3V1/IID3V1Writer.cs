using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    /// <summary>
    /// Interface for a ID3V1 writer. Writes Tags to a file
    /// </summary>
    public interface IID3V1Writer
    {
        /// <summary>
        /// Write tags to a file
        /// </summary>
        /// <param name="file">The ID3V1 file to write to </param>
        void Write(IID3V1 file);
    }
}
