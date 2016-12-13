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
        private string album;
        private uint track;
        private string title;
        private string artist;
        private string genre;
        private string language;
        private byte version;
        /// <summary>
        /// Initializes the file
        /// </summary>
        /// <param name="filepath">The filepath</param>
        public Id3V2(string filepath) :
            base(filepath)
        {
        }

        /// <summary>
        /// Returns the name of the Album and sets it
        /// </summary>
        public string Album
        {
            get { return album; }
            set { album = value; }
        }

        /// <summary>
        /// Returns the Tracknumber and sets it
        /// </summary>
        public uint Track
        {
            get { return track; }
            set { track = value; }
        }

        /// <summary>
        /// Returns the Songtitle ans sets it
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// Returns the Artist and sets it
        /// </summary>
        public string Artist
        {
            get
            {
                return artist;
            }
            set { artist = value; }
        }

        /// <summary>
        /// Returns the Genre and sets it
        /// </summary>
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        /// <summary>
        /// Returns the language and sets it
        /// </summary>
        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        /// <summary>
        /// Returns the version and sets it
        /// </summary>
        public byte Version
        {
            get { return version; }
            set { version = value; }
        }
    }
}
