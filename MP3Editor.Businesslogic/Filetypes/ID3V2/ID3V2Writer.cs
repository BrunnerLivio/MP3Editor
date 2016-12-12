using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MP3Editor.Businesslogic.Filetypes.ID3V2
{
    /// <summary>
    /// Write ID3V2 Tags
    /// </summary>
    public class ID3V2Writer : IID3V2Writer
    {
        /// <summary>
        /// Write to the ID3V2 file
        /// </summary>
        /// <param name="file">The ID3V2 which should get written</param>
        public void Write(Id3V2 file)
        {

            using (TagLib.File taglibFile = TagLib.File.Create(file.FilePath))
            {
                TagLib.Id3v2.Tag tags = taglibFile.GetTag(TagTypes.Id3v2) as TagLib.Id3v2.Tag;
                file.Tag.CopyTo(tags, true);
                tags.Version = file.Tag.Version;
                taglibFile.Save();
            }
        }
    }
}
