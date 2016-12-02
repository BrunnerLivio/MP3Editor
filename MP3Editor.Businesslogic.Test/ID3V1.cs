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
        private int year = 1981;
        private string title = "Give Me The Night";
        private int track = 1;
        private Mock<IID3V1> CreateID3V1File()
        {
            var id3v1file = new Mock<IID3V1>();
            id3v1file.Setup(i => i.Filename)
                .Returns(filepath);

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

            id3v1file.Setup(i => i.Save());
            return id3v1file;
        }
        [TestMethod]
        public void ReadFile()
        {
            Mock<IID3V1> id3v1file = CreateID3V1File();
            

            var reader = new Mock<IFileTypeReader>();
            

            reader
                .Setup(r => r.Read(filepath))
                .Returns(id3v1file.Object);

            IID3V1 file = (IID3V1)reader.Object.Read(filepath);
            Assert.AreEqual(file.Filename, filepath);
            Assert.AreEqual(file.Album, album);
            Assert.AreEqual(file.Comment, comment);
            Assert.AreEqual(file.Genre, genre);
            Assert.AreEqual(file.Track, track);
            Assert.AreEqual(file.Title, title);
            Assert.AreEqual(file.Year, year);
        }

        [TestMethod]
        public void WriteFile()
        {
            
            var reader = new Mock<IFileTypeReader>();
            var id3v1file = CreateID3V1File();

            reader
                .Setup(r => r.Read(filepath))
                .Returns(id3v1file.Object);

            IID3V1 file = (IID3V1)reader.Object.Read(filepath);
            Assert.AreEqual(file.Album, album);
            file.Save();
        }
    }
}
