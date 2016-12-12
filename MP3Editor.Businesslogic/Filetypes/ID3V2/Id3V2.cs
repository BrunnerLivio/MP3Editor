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
        private TagLib.Id3v2.Tag tag;
        /// <summary>
        /// Initializes the file
        /// </summary>
        /// <param name="tag">The tag provided from TagLib, which should be read or written from</param>
        /// <param name="filepath">The filepath</param>
        public Id3V2(TagLib.Id3v2.Tag tag, string filepath) :
            base(filepath)
        {
            this.tag = tag;
        }

        /// <summary>
        /// Returns the Tags
        /// </summary>
        public TagLib.Id3v2.Tag Tag
        {
            get { return this.tag; }
        }

        /// <summary>
        /// Returns the name of the Album and sets it
        /// </summary>
        public string Album
        {
            get { return tag.Album; }
            set { tag.Album = value; }
        }

        /// <summary>
        /// Returns the Tracknumber and sets it
        /// </summary>
        public int Track
        {
            get { return Convert.ToInt32(tag.Track); }
            set { tag.Track = Convert.ToUInt32(value); }
        }

        /// <summary>
        /// Returns the Songtitle ans sets it
        /// </summary>
        public string Title
        {
            get { return tag.Title; }
            set { tag.Title = value; }
        }

        /// <summary>
        /// Returns the Artist and sets it
        /// </summary>
        public string Artist
        {
            get
            {
                if (tag.Artists.Length == 0)
                {
                    return String.Empty;
                }
                return tag.Artists[0];
            }
            set { tag.Artists = new string[] { value }; }
        }

        /// <summary>
        /// Returns the Genre and sets it
        /// </summary>
        public string Genre
        {
            get
            {
                if (tag.Genres.Length == 0)
                {
                    return String.Empty;
                }
                return tag.Genres[0];
            }
            set { tag.Genres = new string[] { value }; }
        }

        /// <summary>
        /// Returns the language and sets it
        /// </summary>
        public static string Language
        {
            get { return TagLib.Id3v2.Tag.Language; }
            set { TagLib.Id3v2.Tag.Language = value; }
        }

        /// <summary>
        /// Returns the version and sets it
        /// </summary>
        public byte Version
        {
            get { return ((TagLib.Id3v2.Tag) tag).Version; }
            set { ((TagLib.Id3v2.Tag) tag).Version = value; }
        }
    }
}
