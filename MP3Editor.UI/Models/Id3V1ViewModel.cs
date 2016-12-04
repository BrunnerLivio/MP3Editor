using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP3Editor.Businesslogic.Filetypes.ID3V1;

namespace MP3Editor.UI.Models
{
    public class Id3V1ViewModel : ViewModel
    {
        private string path;
        private Id3V1Reader reader;
        private Id3V1 file;

        public Id3V1ViewModel(string path)
        {
            this.path = path;
            reader = new Id3V1Reader();
            file = (Id3V1)reader.Read(path);
        }

        public string Album
        {
            get { return file.Album; }
            set { file.Album = value; }
        }

        public void Save()
        {
            file.Save();
        }
    }
}
