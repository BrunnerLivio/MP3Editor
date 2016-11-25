using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    public class Id3V1 : File, IID3V1
    {

        public Id3V1(TagLib.File file)
            :base(file, file.GetTag(TagTypes.Id3v1))
        {
        }

        public string Filename
        {
            get { return file.Name; }
        }

        public string Album
        {
            get { return tag.Album; }
            set { tag.Album = value; }
        }
    }
}
