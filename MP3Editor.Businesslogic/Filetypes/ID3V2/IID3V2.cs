using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Filetypes.ID3V2
{
    public interface IID3V2
    {
        string Filename { get; }
        string Album { get; set; }
        int Track { get; set; }
        string Title { get; set; }
        string Artist { get; set; }
        string Genre { get; set; }
    }
}
