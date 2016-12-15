using System;
using System.Runtime.Remoting;
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
        private string artist = "George Benson";
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
        public void ID3V1Properties()
        {
            Filetypes.ID3V1.Id3V1 file = new Filetypes.ID3V1.Id3V1(filepath);
            Assert.AreEqual(filepath, file.FilePath);
            file.Album = album;
            Assert.AreEqual(album, file.Album);
            file.AlbumArtist = artist;
            Assert.AreEqual(artist, file.AlbumArtist);
            file.Comment = comment;
            Assert.AreEqual(comment, file.Comment);
            file.Genre = genre;
            Assert.AreEqual(genre, file.Genre);
            file.Title = title;
            Assert.AreEqual(title, file.Title);
            file.Track = track;
            Assert.AreEqual(track, file.Track);
            file.Year = year;
            Assert.AreEqual(year, file.Year);
        }

        [TestMethod]
        public void WriteFile()
        {
            
            var writer = new Mock<IID3V1Writer>();
            writer
                .Setup(r => r.Write(new Filetypes.ID3V1.Id3V1(filepath)));
        }

        [TestMethod]
        public void ReadFile()
        {

            var writer = new Mock<IFileTypeReader>();
            writer
                .Setup(r => r.Read(filepath))
                .Returns(new Filetypes.ID3V1.Id3V1(filepath));

            Filetypes.ID3V1.Id3V1 file = writer.Object.Read(filepath) as Filetypes.ID3V1.Id3V1;
            Assert.AreEqual(filepath, file.FilePath);
        }
    }
}
