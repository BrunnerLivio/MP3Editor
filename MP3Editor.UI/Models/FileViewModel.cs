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
    /// <summary>
    /// Represents one file
    /// </summary>
    public class FileViewModel : ViewModel, IDisposable
    {
        private string path;
        private string name;
        private long size;
        private FileInfo fileInfo;
        private Id3V1ViewModel id3V1ViewModel;
        private Id3V2ViewModel id3V2ViewModel;

        /// <summary>
        /// Initializes the File View Model
        /// </summary>
        /// <param name="path">The absolute path of the file</param>
        public FileViewModel(string path)
        {
            this.path = path;
            fileInfo = new FileInfo(path);
        }

        /// <summary>
        /// Load Id3V1 data
        /// </summary>
        public void LoadId3V1()
        {
            id3V1ViewModel = new Id3V1ViewModel(path);
            OnPropertyChanged("Id3V1ViewModel");
        }

        /// <summary>
        /// Load Id3V1 data
        /// </summary>
        public void LoadId3V2()
        {
            id3V2ViewModel = new Id3V2ViewModel(path);
            OnPropertyChanged("Id3V2ViewModel");
        }

        /// <summary>
        /// Return the Name of the file
        /// </summary>
        public string Name
        {
            get { return fileInfo.Name; }
        }

        /// <summary>
        /// Return the Size of the file
        /// </summary>
        public long Size
        {
            get { return fileInfo.Length; }
        }

        /// <summary>
        /// Return the absolute Path of the file
        /// </summary>
        public string Path
        {
            get { return path; }
        }

        /// <summary>
        /// Return the Id3V1ViewModel
        /// </summary>
        public Id3V1ViewModel Id3V1ViewModel
        {
            get { return id3V1ViewModel; }
        }

        /// <summary>
        /// Return the Id3V2ViewModel
        /// </summary>
        public Id3V2ViewModel Id3V2ViewModel
        {
            get { return id3V2ViewModel; }
        }

        /// <summary>
        /// Save both ID3V1 and ID3V2 tags.
        /// </summary>
        public void Save()
        {
            if (id3V1ViewModel != null)
            {
                id3V1ViewModel.Save();
            }
            if (id3V2ViewModel != null)
            {
                id3V2ViewModel.Save();
            }
        }

        /// <summary>
        /// Unlaod the id3v1 file
        /// </summary>
        public void UnloadId3V1()
        {
            id3V1ViewModel = null;
        }

        /// <summary>
        /// Unload the id3v2 file
        /// </summary>
        public void UnloadId3V2()
        {
            id3V2ViewModel = null;
        }

        /// <summary>
        /// Unload Id3V1 and Id3V2
        /// </summary>
        public void Dispose()
        {
            UnloadId3V1();
            UnloadId3V2();
        }
    }
}
