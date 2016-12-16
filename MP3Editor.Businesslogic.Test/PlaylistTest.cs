using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MP3Editor.Businesslogic.Test
{
    [TestClass]
    public class PlaylistTest
    {
        [TestMethod]
        public void AddList()
        {
            Playlist.Playlist playlist = new Playlist.Playlist();
            playlist.Add("C:/Musik/Hardcoredeathmetalpussyshit.mp3");
            Assert.AreEqual("C:/Musik/Hardcoredeathmetalpussyshit.mp3", playlist.Files.First().FilePath);
        }

        [TestMethod]
        public void ParseFile()
        {
            Playlist.Playlist playlist = new Playlist.Playlist();
            List<File> files = playlist.ParseFile(new[] {"#test", "#de ficker", "muschi", "futze", "#### asdf @@@"});
            Assert.AreEqual("muschi", files.First().FilePath);
            Assert.AreEqual("futze", files.Skip(1).First().FilePath);
            Assert.AreEqual(2, files.Count);
        }

        [TestMethod]
        public void M3UText()
        {
            Playlist.Playlist playlist = new Playlist.Playlist();
            playlist.Add("yourmother");
            playlist.Add("yourmother2");
            Assert.AreEqual(string.Format("#EXTM3U{0}yourmother{0}yourmother2{0}", Environment.NewLine), playlist.M3UText);
        }
    }
}
