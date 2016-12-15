using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP3Editor.Businesslogic;
using MP3Editor.Businesslogic.Filetypes.ID3V1;
using MP3Editor.Businesslogic.Filetypes.ID3V2;
using MP3Editor.Businesslogic.Language;

namespace MP3Editor.UI.Models
{
    public class Id3V2ViewModel : ViewModel
    {
        private string path;
        private ID3V2Reader reader;
        private Id3V2 file;
        private ID3V2Writer writer;

        /// <summary>
        /// Initialize and read ID3V2 Tags of the file
        /// </summary>
        /// <param name="path">The path of the file</param>
        public Id3V2ViewModel(string path)
        {
            this.path = path;
            reader = new ID3V2Reader();
            writer = new ID3V2Writer();
            file = (Id3V2)reader.Read(path);
            OnPropertyChanged("Language");
        }

        /// <summary>
        /// Returns the Album and sets it
        /// </summary>
        /// <remarks>
        /// To write to the actual file, call <see cref="Save"/>
        /// </remarks>
        public string Album
        {
            get { return file.Album; }
            set
            {
                file.Album = value;
                OnPropertyChanged("Album");
            }
        }

        /// <summary>
        /// Returns the Artist and sets it
        /// </summary>
        /// <remarks>
        /// To write to the actual file, call <see cref="Save"/>
        /// </remarks>
        public string Artist
        {
            get { return file.Artist; }
            set
            {
                file.Artist = value;
                OnPropertyChanged("Artist");
            }
        }

        /// <summary>
        /// Returns the Genre and sets it
        /// </summary>
        /// <remarks>
        /// To write to the actual file, call <see cref="Save"/>
        /// </remarks>
        public string Genre
        {
            get { return file.Genre; }
            set
            {
                file.Genre = value;
                OnPropertyChanged("Genre");
            }
        }

        /// <summary>
        /// Returns the Title and sets it
        /// </summary>
        /// <remarks>
        /// To write to the actual file, call <see cref="Save"/>
        /// </remarks>
        public string Title
        {
            get { return file.Title; }
            set
            {
                file.Title = value;
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Returns the Track and sets it
        /// </summary>
        /// <remarks>
        /// To write to the actual file, call <see cref="Save"/>
        /// </remarks>
        public uint Track
        {
            get { return file.Track; }
            set
            {
                file.Track = value;
                OnPropertyChanged("Track");
            }
        }

        /// <summary>
        /// Returns the Language and sets it
        /// </summary>
        /// <remarks>
        /// To write to the actual file, call <see cref="Save"/>
        /// </remarks>
        public Language Language
        {
            get { return LanguageRepository.GetByShortname(file.Language); }
            set
            {
                file.Language = value.Shortname;
                OnPropertyChanged("Language");
            }
        }

        /// <summary>
        /// Returns the version and sets it
        /// </summary>
        /// <remarks>
        /// To write to the actual file, call <see cref="Save"/>
        /// </remarks>
        public byte Version
        {
            get { return file.Version; }
            set
            {
                file.Version = value;
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Write the data to the file
        /// </summary>
        public void Save()
        {
            writer.Write(file);
        }

    }
}
