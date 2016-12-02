using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MP3Editor.Businesslogic.Filetypes.ID3V2
{
    public class Id3V2 : File, IID3V2
    {
        public Id3V2(TagLib.File file) : 
            base(file)
        {
        }

        public string Album
        {
            get { return file.Tag.Album; }

            set { file.Tag.Album = value; }
        }

        public int Track
        {
            get { return Convert.ToInt32(file.Tag.Track); }
            set { file.Tag.Track = Convert.ToUInt32(value); }
        }

        public string Title
        {
            get { return file.Tag.Title; }
            set { file.Tag.Title = value; }
        }

        public string Artist
        {
            get { return file.Tag.Artists[0]; }
            set { file.Tag.Artists[0] = value; }
        }

        public string Genre
        {
            get { return file.Tag.Genres[0]; }
            set { file.Tag.Genres[0] = value; }
        }

        public string Filename
        {
            get { return file.Name; }
        }

        public override void Save()
        {
            file.Save();
        }
    }
}
