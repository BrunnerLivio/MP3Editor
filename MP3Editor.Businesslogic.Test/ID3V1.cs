using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MP3Editor.Businesslogic.Filetypes.ID3V1;

namespace MP3Editor.Businesslogic.Test
{
    [TestClass]
    public class Id3V1
    {
        private string filepath = "Give Me The Night.mp3";
        private string album = "George Benson Best Hits";
        private string comment = "My comment xD";
        private string genre = "Pop";
        private uint year = 1981;
        private string title = "Give Me The Night";
        private uint track = 1;
        private Mock<IID3V1> CreateID3V1File()
        {
            var id3v1file = new Mock<IID3V1>();

            id3v1file.Setup(i => i.Album)
                .Returns(album);

            id3v1file.Setup(i => i.Comment)
                .Returns(comment);

            id3v1file.Setup(i => i.Genre)
                .Returns(genre);

            id3v1file.Setup(i => i.Year)
                .Returns(year);

            id3v1file.Setup(i => i.Track)
                .Returns(track);

            id3v1file.Setup(i => i.Title)
                .Returns(title);
            return id3v1file;
        }
        [TestMethod]
        public void Properties()
        {
            Id3V1 file = new Id3V1();
        }

        [TestMethod]
        public void WriteFile()
        {
            
            var writer = new Mock<IID3V1Writer>();
            var id3v1file = CreateID3V1File();

            id3v1file.Object.Genre = "My Genre";

            writer
                .Setup(r => r.Write(id3v1file.Object));
        }
    }
}
