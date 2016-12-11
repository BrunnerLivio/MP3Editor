﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP3Editor.Businesslogic;
using MP3Editor.Businesslogic.Filetypes.ID3V1;
using MP3Editor.Businesslogic.Filetypes.ID3V2;

namespace MP3Editor.UI.Models
{
    public class Id3V2ViewModel: ViewModel
    {
        private string path;
        private ID3V2Reader reader;
        private Id3V2 file;
        private IFileTypeWriter writer;

        /// <summary>
        /// Initialize and read ID3V2 Tags of the file
        /// </summary>
        /// <param name="path">The path of the file</param>
        public Id3V2ViewModel(string path)
        {
            this.path = path;
            reader = new ID3V2Reader();
            writer = new FileTypeWriter();
            file = (Id3V2)reader.Read(path);
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
                OnPropertyChanged("Genre");
            }
        }

        public int Track
        {
            get { return file.Track; }
            set
            {
                file.Track = value;
                OnPropertyChanged("Track");
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
