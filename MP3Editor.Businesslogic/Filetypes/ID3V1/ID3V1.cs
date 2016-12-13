using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    /// <summary>
    /// Represents a data file which reprensents one MP3 file.
    /// This class writes to the ID3V1 attributes of this file
    /// </summary>
    public class Id3V1 : File, IID3V1, IFile
    {
        private string filePath;
        private string album;
        private string albumArtist;
        private string comment;
        private uint track;
        private string title;
        private string genre;
        private uint year;
        /// <summary>
        /// Initializes the file
        /// </summary>
        /// <param name="filePath">The path of the file</param>
        public Id3V1(string filePath)
            :base(filePath)
        {
        }


        /// <summary>
        /// Returns the Album of the mp3 file
        /// and writes it
        /// </summary>
        public string Album
        {
            get { return album; }
            set { album = value; }
        }

        /// <summary>
        /// Returns the Album Artists and 
        /// writes it
        /// </summary>
        public string AlbumArtist
        {
            get { return albumArtist; }
            set { albumArtist = value; }
        }

        /// <summary>
        /// Returns the comment of the file and writes it
        /// </summary>
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        /// <summary>
        /// Returns the track number and sets it
        /// </summary>
        public uint Track
        {
            get { return track; }

            set { track = value;  }
        }

        /// <summary>
        /// Returns the title of the file and sets it.
        /// </summary>
        public string Title
        {
            get { return title; }

            set { title = value; }
        }

        /// <summary>
        /// Returns the genre of the file and set it.
        /// </summary>
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        /// <summary>
        /// Returns the release-year and sets it
        /// </summary>
        public uint Year
        {
            get { return year; }

            set { year = value; }
        }
    }
}
