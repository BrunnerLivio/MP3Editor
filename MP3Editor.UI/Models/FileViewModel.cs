using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP3Editor.Businesslogic;
using MP3Editor.Businesslogic.Filetypes.ID3V1;
using MP3Editor.UI.Models;

namespace MP3Editor.UI.Models
{
    public class FileViewModel : ViewModel
    {
        private string path;
        private string name;
        private long size;
        private FileInfo fileInfo;
        private Id3V1ViewModel id3V1ViewModel;

        public FileViewModel(string path)
        {
            this.path = path;
            fileInfo = new FileInfo(path);
        }

        public void LoadId3V1()
        {
            id3V1ViewModel = new Id3V1ViewModel(path);
            OnPropertyChanged("Id3V1ViewModel");
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

        public Id3V1ViewModel Id3V1ViewModel
        {
            get { return id3V1ViewModel; }
        }

        public void Save()
        {
            if (id3V1ViewModel != null)
            {
                id3V1ViewModel.Save();
            }
        }
    }
}
