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
        protected File(TagLib.File file)
        {
            this.file = file;
        }

        public abstract void Save();
    }
}
