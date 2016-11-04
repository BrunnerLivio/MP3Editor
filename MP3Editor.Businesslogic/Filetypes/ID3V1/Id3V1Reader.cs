using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    public class Id3V1Reader : IFileTypeReader
    {
        public File Read(string filepath)
        {
            TagLib.File file = TagLib.File.Create(filepath);
            return new Id3V1()
            {
                Filename = file.Name
            };
        }
    }
}
