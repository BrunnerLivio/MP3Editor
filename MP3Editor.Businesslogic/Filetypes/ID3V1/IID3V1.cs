using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    public interface IID3V1 : IFile
    {
        string Album { get; set; }
        string Filename { get; }
    }
}
