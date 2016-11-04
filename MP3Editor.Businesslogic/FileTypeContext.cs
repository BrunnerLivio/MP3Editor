using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic
{
    public class FileTypeContext
    {
        private IFileTypeReader fileType;
        public File Read(string filepath)
        {
            return this.fileType.Read(filepath);
        }

        public void SetFileTypeReader(IFileTypeReader fileType)
        {
            this.fileType = fileType;
        }
    }
}
