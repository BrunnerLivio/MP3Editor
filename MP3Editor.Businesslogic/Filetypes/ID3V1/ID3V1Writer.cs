using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    public class ID3V1Writer : IFileTypeWriter
    {
        public void Save(IFile fileToSave)
        {
            fileToSave.GetFile().Save();
        }
    }
}
