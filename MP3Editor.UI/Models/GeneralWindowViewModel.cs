﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// Initializes the General Window
        /// </summary>
        /// <param name="file">The FileViewModel which should get represented</param>
        public GeneralWindowViewModel(FileViewModel file)
        {
            this.file = file;
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
    }
}
