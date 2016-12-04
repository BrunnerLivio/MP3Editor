using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP3Editor.UI.Models;

namespace MP3Editor.UI.Models
{
    public class FileViewModel : ViewModel
    {
        private string path;
        private string name;
        private long size;
        private FileInfo fileInfo;

        public FileViewModel(string path)
        {
            this.path = path;
            fileInfo = new FileInfo(path);
        }


        public string Name
        {
            get { return fileInfo.Name; }
        }

        public long Size
        {
            get { return fileInfo.Length; }
        }

        public string Path
        {
            get { return path; }
        }
    }
}
