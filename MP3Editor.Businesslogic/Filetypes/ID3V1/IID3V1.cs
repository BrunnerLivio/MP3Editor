using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    /// <summary>
    /// Represents an ID3V1 file
    /// </summary>
    public interface IID3V1 : IFile
    {
        /// <summary>
        /// Returns the Album and sets it
        /// </summary>
        string Album { get; set; }
        /// <summary>
        /// Returns the Filename
        /// </summary>
        string FilePath { get; }
        /// <summary>
        /// Returns the Tracknumber and sets it
        /// </summary>
        uint Track { get; set; }
        /// <summary>
        /// Returns the Songtitle and sets it
        /// </summary>
        string Title { get; set; }
        /// <summary>
        /// Returns the Album Artists and sets them
        /// </summary>
        string AlbumArtist { get; set; }
        /// <summary>
        /// Returns the Genre and sets it
        /// </summary>
        string Genre { get; set; }
        /// <summary>
        /// Returns the Creationyear and sets it
        /// </summary>
        uint Year { get; set; }
        /// <summary>
        /// Returns the Comment and sets it
        /// </summary>
        string Comment { get; set; }
    }
}
