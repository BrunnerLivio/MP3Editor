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
            TagLib.Id3v1.Tag tags;
            IID3V1 newFile = new Id3V1(filepath);
            using (TagLib.File file = TagLib.File.Create(filepath))
            {
                tags = file.GetTag(TagTypes.Id3v1) as TagLib.Id3v1.Tag;
                if (tags.Performers.Length == 0)
                {
                    newFile.AlbumArtist = String.Empty;
                }
                else
                {
                    newFile.AlbumArtist = tags.Performers[0];
                }
                newFile.Album = tags.Album;
                newFile.Comment = tags.Comment;
                if (tags.Genres.Length == 0)
                {
                    newFile.Genre = String.Empty;
                }
                else
                {
                    newFile.Genre = tags.Genres[0];
                }
                newFile.Title = tags.Title;
                newFile.Track = tags.Track;
                newFile.Year = tags.Year;
            }
            return newFile;
        }
    }
}
