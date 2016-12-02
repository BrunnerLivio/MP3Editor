using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Filetypes.ID3V2
{
    public class ID3V2Reader : IFileTypeReader
    {
        public IFile Read(string filepath)
        {
            TagLib.File file = TagLib.File.Create(filepath);
            return new Id3V2(file);
        }
    }
}
