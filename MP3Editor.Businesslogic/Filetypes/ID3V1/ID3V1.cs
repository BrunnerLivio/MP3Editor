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
    public class Id3V1 : File, IID3V1
    {
        /// <summary>
        /// Initializes the file
        /// </summary>
        /// <param name="file">The file provided from TagLib, which should be read or written from</param>
        public Id3V1(TagLib.File file)
            :base(file)
        {
        }

        /// <summary>
        /// Returns the filename
        /// </summary>
        public string Filename
        {
            get { return file.Name; }
        }

        /// <summary>
        /// Returns the Album of the mp3 file
        /// and writes it
        /// </summary>
        public string Album
        {
            get { return file.Tag.Album; }
            set { file.Tag.Album = value; }
        }

        /// <summary>
        /// Returns the Album Artists and 
        /// writes it
        /// </summary>
        public string AlbumArtist
        {
            get
            {
                if (file.Tag.AlbumArtists.Length == 0)
                {
                    return String.Empty;
                }
                return file.Tag.AlbumArtists[0];
            }
            set { file.Tag.AlbumArtists = new string[] { value }; }
        }

        /// <summary>
        /// Returns the comment of the file and writes it
        /// </summary>
        public string Comment
        {
            get { return file.Tag.Comment; }
            set { file.Tag.Comment = value; }
        }

        /// <summary>
        /// Returns the track number and sets it
        /// </summary>
        public int Track
        {
            get { return Convert.ToInt32(file.Tag.Track); }

            set { file.Tag.Track = Convert.ToUInt32(value); }
        }

        /// <summary>
        /// Returns the title of the file and sets it.
        /// </summary>
        public string Title
        {
            get { return file.Tag.Title; }

            set { file.Tag.Title = value; }
        }

        /// <summary>
        /// Returns the genre of the file and set it.
        /// </summary>
        public string Genre
        {
            get { return file.Tag.Genres[0]; }

            set { file.Tag.Genres[0] = value; }
        }

        /// <summary>
        /// Returns the release-year and sets it
        /// </summary>
        public int Year
        {
            get { return Convert.ToInt32(file.Tag.Year); }

            set { file.Tag.Year = Convert.ToUInt32(value); }
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
