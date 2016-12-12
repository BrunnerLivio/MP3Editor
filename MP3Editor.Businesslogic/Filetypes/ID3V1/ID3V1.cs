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
        private TagLib.Id3v1.Tag tag;
        private string filePath;
        /// <summary>
        /// Initializes the file
        /// </summary>
        /// <param name="filePath">The path of the file</param>
        /// <param name="tag">The tag provided from TagLib, which should be read or written from</param>
        public Id3V1(TagLib.Id3v1.Tag tag, string filePath)
            :base(filePath)
        {
            this.tag = tag;
        }

        /// <summary>
        /// Returns the ID3V1 Tags
        /// </summary>
        public TagLib.Id3v1.Tag Tag
        {
            get { return this.tag; }
        }

        /// <summary>
        /// Returns the Album of the mp3 file
        /// and writes it
        /// </summary>
        public string Album
        {
            get { return tag.Album; }
            set { tag.Album = value; }
        }

        /// <summary>
        /// Returns the Album Artists and 
        /// writes it
        /// </summary>
        public string AlbumArtist
        {
            get
            {
                if (tag.Performers.Length == 0)
                {
                    return String.Empty;
                }
                return tag.Performers[0];
            }
            set { tag.Performers = new string[1] { value }; }
        }

        /// <summary>
        /// Returns the comment of the file and writes it
        /// </summary>
        public string Comment
        {
            get { return tag.Comment; }
            set { tag.Comment = value; }
        }

        /// <summary>
        /// Returns the track number and sets it
        /// </summary>
        public int Track
        {
            get { return Convert.ToInt32(tag.Track); }

            set { tag.Track = Convert.ToUInt32(value); }
        }

        /// <summary>
        /// Returns the title of the file and sets it.
        /// </summary>
        public string Title
        {
            get { return tag.Title; }

            set { tag.Title = value; }
        }

        /// <summary>
        /// Returns the genre of the file and set it.
        /// </summary>
        public string Genre
        {
            get {
                if (tag.Genres.Length == 0)
                {
                    return String.Empty;
                }
                return tag.Genres[0];
            }
            set { tag.Genres = new string[] { value }; }
        }

        /// <summary>
        /// Returns the release-year and sets it
        /// </summary>
        public int Year
        {
            get { return Convert.ToInt32(tag.Year); }

            set { tag.Year = Convert.ToUInt32(value); }
        }
    }
}
