using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic
{
    class FileTypeContext
    {
        private IFileTypeReader fileType;
        public IFile Read(string filepath)
        {
            return this.fileType.Read(filepath);
        }

        public void SetFileType(IFileTypeReader fileType)
        {
            this.fileType = fileType;
        }
    }
}
