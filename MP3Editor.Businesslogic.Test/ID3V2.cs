using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP3Editor.Businesslogic.Filetypes.ID3V2;

namespace MP3Editor.Businesslogic.Test
{
    [TestClass]
    public class ID3V2
    {
        private string language = "DE";
        private string filepath = "Give Me The Night.mp3";
        private string album = "George Benson Best Hits";
        private string comment = "My comment xD";
        private string genre = "Pop";
        private uint year = 1981;
        private string title = "Give Me The Night";
        private string artist = "George Benson";
        private uint track = 1;
        private byte version = 1;
        [TestMethod]
        public void ID3V2Properties()
        {
            Id3V2 file = new Id3V2(filepath);
            file.Language = language;
            Assert.AreEqual(language, file.Language);
            file.Album = album;
            Assert.AreEqual(album, file.Album);
            file.Artist = artist;
            Assert.AreEqual(artist, file.Artist);
            file.Genre = genre;
            Assert.AreEqual(genre, file.Genre);
            file.Title = title;
            Assert.AreEqual(title, file.Title);
            file.Track = track;
            Assert.AreEqual(track, file.Track);
            file.Version = version;
            Assert.AreEqual(version, file.Version);
        }
    }
}
