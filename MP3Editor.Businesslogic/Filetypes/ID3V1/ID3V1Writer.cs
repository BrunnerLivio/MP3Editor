using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    /// <summary>
    /// Write ID3V1 Tags
    /// </summary>
    public class ID3V1Writer : IID3V1Writer
    {
        /// <summary>
        /// Write to the ID3V1 file
        /// </summary>
        /// <param name="file">The ID3V1 which should get written</param>
        public void Write(IID3V1 file)
        {
            
            using (TagLib.File taglibFile = TagLib.File.Create(file.FilePath))
            {
                file.Tag.CopyTo(taglibFile.Tag, true);
                taglibFile.Save();
            }
        }
    }
}
