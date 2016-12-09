using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Filetypes.ID3V2
{
    public interface IID3V2
    {
        /// <summary>
        /// Retursn the Filename
        /// </summary>
        string Filename { get; }
        /// <summary>
        /// Returns the Album and sets it
        /// </summary>
        string Album { get; set; }
        /// <summary>
        /// Returns the Tracknumber and sets it
        /// </summary>
        int Track { get; set; }
        /// <summary>
        /// Returns the Songtitle and sets it
        /// </summary>
        string Title { get; set; }
        /// <summary>
        /// Returns the Artist and sets it
        /// </summary>
        string Artist { get; set; }
        /// <summary>
        /// Returns the Genre and sets it
        /// </summary>
        string Genre { get; set; }
    }
}
