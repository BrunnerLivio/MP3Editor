using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.UI.Models
{
    public class GeneralWindowViewModel : ViewModel
    {
        private FileViewModel file;
        private bool isID3V1Checked = false;
        public GeneralWindowViewModel(FileViewModel file)
        {
            this.file = file;
        }

        public FileViewModel File
        {
            get { return this.file; }
        }

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
    }
}
