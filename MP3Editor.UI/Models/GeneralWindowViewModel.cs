using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP3Editor.Businesslogic.Genre;
using MP3Editor.Businesslogic.Language;

namespace MP3Editor.UI.Models
{
    /// <summary>
    /// The ViewModel for the General Window
    /// </summary>
    public class GeneralWindowViewModel : ViewModel
    {
        private FileViewModel file;
        private bool isID3V1Checked = false;
        private bool isID3V2Checked = false;
        private List<String> genres = new List<string>();
        private List<Language> languages =new List<Language>();
        /// <summary>
        /// Initializes the General Window
        /// </summary>
        /// <param name="file">The FileViewModel which should get represented</param>
        public GeneralWindowViewModel(FileViewModel file)
        {
            this.file = file;
            GenreFactory genreFactory = new GenreFactory();
            this.genres = genreFactory
                .GetAllAudioGenres()
                .Select(g => g.Name)
                .ToList();
            this.languages = LanguageFactory
                .GetAll();
        }

        /// <summary>
        /// Returns the File, which gets represented
        /// </summary>
        public FileViewModel File
        {
            get { return this.file; }
        }

        /// <summary>
        /// Returns if the Is ID3V1 is active or not
        /// When is turned on, it loads ID3V1, off, it unloads
        /// </summary>
        public bool IsID3V1Checked
        {
            get
            {
                return isID3V1Checked; 
            }
            set
            {
                if (value)
                {
                    File.LoadId3V1();
                }
                else
                {
                    File.UnloadId3V1();
                }
                isID3V1Checked = value;
                OnPropertyChanged("IsID3V1Checked");
            }
        }

        /// <summary>
        /// Returns if the Is ID3V2 is active or not
        /// When is turned on, it loads ID3V2, off, it unloads
        /// </summary>
        public bool IsID3V2Checked
        {
            get
            {
                return isID3V2Checked;
            }
            set
            {
                if (value)
                {
                    File.LoadId3V2();
                }
                else
                {
                    File.UnloadId3V2();
                }
                isID3V2Checked = value;
                OnPropertyChanged("IsID3V2Checked");
            }
        }

        /// <summary>
        /// Copy data from id3v1
        /// </summary>
        public void CopyFromVersion1()
        {
            if (IsID3V2Checked)
            {
                File.Id3V2ViewModel.Album = File.Id3V1ViewModel.Album;
                File.Id3V2ViewModel.Artist = File.Id3V1ViewModel.AlbumArtist;
                File.Id3V2ViewModel.Genre = File.Id3V1ViewModel.Genre;
                File.Id3V2ViewModel.Track = File.Id3V1ViewModel.Track;
                File.Id3V2ViewModel.Title = File.Id3V1ViewModel.Title;
            }
        }

        /// <summary>
        /// Copy Data from Id3V2
        /// </summary>
        public void CopyFromVersion2()
        {
            if (IsID3V1Checked)
            {
                File.Id3V1ViewModel.Album = File.Id3V2ViewModel.Album;
                File.Id3V1ViewModel.AlbumArtist = File.Id3V2ViewModel.Artist;
                File.Id3V1ViewModel.Genre = File.Id3V2ViewModel.Genre;
                File.Id3V1ViewModel.Track = File.Id3V2ViewModel.Track;
                File.Id3V1ViewModel.Title = File.Id3V2ViewModel.Title;
            }
        }

        /// <summary>
        /// Returns a list of genres
        /// </summary>
        public List<String> Genres
        {
            get { return this.genres; }
        }

        /// <summary>
        /// Returns a list of languages
        /// </summary>
        public List<Language> Languages
        {
            get { return this.languages; }
        }
    }
}
