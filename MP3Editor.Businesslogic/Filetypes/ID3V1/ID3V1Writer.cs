using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

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
                TagLib.Id3v1.Tag tags = taglibFile.GetTag(TagTypes.Id3v1) as TagLib.Id3v1.Tag;
                tags.Album = file.Album;
                tags.Performers = new[] {file.AlbumArtist};
                tags.Year = file.Year;
                tags.Comment = file.Comment;
                tags.Genres = new[] {file.Genre};
                tags.Title = file.Title;
                tags.Track = file.Track;
                taglibFile.Save();
            }
        }
    }
}
