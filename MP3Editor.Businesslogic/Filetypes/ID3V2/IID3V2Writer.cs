using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Filetypes.ID3V2
{
    /// <summary>
    /// Interface for a ID3V2 writer. Writes Tags to a file
    /// </summary>
    interface IID3V2Writer
    {
        /// <summary>
        /// Write tags to a file
        /// </summary>
        /// <param name="file">The ID3V2 file to write to </param>
        void Write(Id3V2 file);
    }
}
