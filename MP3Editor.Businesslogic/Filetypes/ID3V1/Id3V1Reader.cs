using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    class Id3V1Reader : IFileTypeReader
    {
        public IFile Read(string filepath)
        {
            return new Id3V1()
            {
                Filename = filepath
            };
        }
    }
}
