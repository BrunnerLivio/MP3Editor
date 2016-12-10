using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MP3Editor.Businesslogic.Filetypes.ID3V1
{
    /// <summary>
    /// The Id3V1 strategy to read tags of a mp3 file
    /// using TagLib
    /// </summary>
    public class Id3V1Reader : IFileTypeReader
    {
        /// <summary>
        /// Reads the Id3V1 tags of the given file using TagLib
        /// </summary>
        /// <param name="filepath">The absolute path of the file, which should be read</param>
        /// <returns>A ID3V1 file with the tags</returns>
        public IFile Read(string filepath)
        {
            TagLib.Tag tags;
            using (TagLib.File file = TagLib.File.Create(filepath))
            {
               tags = file.Tag;
            }
            return new Id3V1(filepath, tags);
        }
    }
}
