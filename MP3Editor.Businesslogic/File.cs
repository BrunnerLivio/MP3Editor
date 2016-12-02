using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic
{
    public abstract class File : IFile
    {
        protected TagLib.File file;
        protected TagLib.Tag tag;
        protected File(TagLib.File file, TagLib.Tag tag)
        {
            this.tag = tag;
            this.file = file;
        }

        public abstract void Save();
    }
}
