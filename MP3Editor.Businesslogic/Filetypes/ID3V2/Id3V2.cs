using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MP3Editor.Businesslogic.Filetypes.ID3V2
{
    /// <summary>
    /// Represents a data file which reprensents one MP3 file.
    /// This class writes to the ID3V2 attributes of this file
    /// </summary>
    public class Id3V2 : File, IID3V2
    {
        /// <summary>
        /// Initializes the file
        /// </summary>
        /// <param name="file">The file provided from TagLib, which should be read or written from</param>
        public Id3V2(TagLib.File file) : 
            base(file)
        {
        }

        /// <summary>
        /// Returns the name of the Album and sets it
        /// </summary>
        public string Album
        {
            get { return file.Tag.Album; }
            set { file.Tag.Album = value; }
        }

        /// <summary>
        /// Returns the Tracknumber and sets it
        /// </summary>
        public int Track
        {
            get { return Convert.ToInt32(file.Tag.Track); }
            set { file.Tag.Track = Convert.ToUInt32(value); }
        }

        /// <summary>
        /// Returns the Songtitle ans sets it
        /// </summary>
        public string Title
        {
            get { return file.Tag.Title; }
            set { file.Tag.Title = value; }
        }

        /// <summary>
        /// Returns the Artist and sets it
        /// </summary>
        public string Artist
        {
            get { return file.Tag.Artists[0]; }
            set { file.Tag.Artists[0] = value; }
        }

        /// <summary>
        /// Returns the Genre and sets it
        /// </summary>
        public string Genre
        {
            get { return file.Tag.Genres[0]; }
            set { file.Tag.Genres[0] = value; }
        }

        /// <summary>
        /// Returns the filename
        /// </summary>
        public string Filename
        {
            get { return file.Name; }
        }

        /// <summary>
        /// Finally writes the data to the file using Taglib.
        /// </summary>
        public override void Save()
        {
            file.Save();
        }
    }
}
