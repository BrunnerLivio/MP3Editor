using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MP3Editor.Businesslogic;
using MP3Editor.Businesslogic.Playlist;
using MP3Editor.UI.Properties;

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
        private Playlist playlist = new Playlist();
        /// <summary>
        /// Load a list 
        /// </summary>
        /// <param name="folderpath">The folder to load</param>
        public void LoadList(string path)
        {
            loadedPath = path;
            try
            {
                playlist = new Playlist();
                playlist.Load(path);
                foreach (Businesslogic.File playlistFile in playlist.Files)
                {
                    files.Add(new FileViewModel(playlistFile.FilePath));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Die Datei konnte nicht geladen werden");
            }
        }

        /// <summary>
        /// Saves the playlist
        /// </summary>
        public void SaveList(string path)
        {
            try
            {
                playlist.Save(path);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save the file");
            }
        }
        /// <summary>
        /// Add a file to the playlist and add it to the UI
        /// </summary>
        /// <param name="filepath">The path of the file</param>
        public void AddfileToPlaylist(string filepath)
        {
            playlist.Add(filepath);    
            files.Add(new FileViewModel(filepath));
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

        public void SaveCurrentPath()
        {
            Settings.Default["CurrentPath"] = loadedPath;
            Settings.Default.Save();
        }

        public string GetCurrentPath()
        {
            return string.Empty;
            //return (String)Settings.Default["CurrentPath"];
        }
    }
}
