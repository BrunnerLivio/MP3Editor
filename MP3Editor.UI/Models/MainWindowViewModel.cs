using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.UI.Models
{
    public class MainWindowViewModel : ViewModel
    {
        private string loadedPath;
        private ObservableCollection<FileViewModel> files = new ObservableCollection<FileViewModel>();
        private FileViewModel selectedFile;
        public void LoadList(string folderpath)
        {
            loadedPath = folderpath;
            foreach (string filepath in Directory.GetFiles(loadedPath).Where(p => p.EndsWith("mp3")))
            {
                files.Add(new FileViewModel(filepath));
            }
        }

        public ObservableCollection<FileViewModel> Files
        {
            get { return files; }
        }

        public FileViewModel SelectedFile
        {
            get { return selectedFile; }
            set { selectedFile = value; }
        }
    }
}
