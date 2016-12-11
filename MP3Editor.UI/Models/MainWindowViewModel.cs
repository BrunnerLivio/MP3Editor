using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.UI.Models
{
    /// <summary>
    /// The ViewModel for the MainWindow
    /// </summary>
    public class MainWindowViewModel : ViewModel
    {
        private string loadedPath;
        private ObservableCollection<FileViewModel> files = new ObservableCollection<FileViewModel>();
        private FileViewModel selectedFile;
        /// <summary>
        /// Load a list 
        /// </summary>
        /// <param name="folderpath">The folder to load</param>
        public void LoadList(string folderpath)
        {
            loadedPath = folderpath;
            foreach (string filepath in Directory.GetFiles(loadedPath).Where(p => p.EndsWith("mp3")))
            {
                files.Add(new FileViewModel(filepath));
            }
        }

        /// <summary>
        /// Returns the files
        /// </summary>
        public ObservableCollection<FileViewModel> Files
        {
            get { return files; }
        }

        /// <summary>
        /// Returns the selected file and sets it
        /// </summary>
        public FileViewModel SelectedFile
        {
            get { return selectedFile; }
            set
            {
                selectedFile = value; 
                OnPropertyChanged("SelectedFile");
            }
        }
    }
}
