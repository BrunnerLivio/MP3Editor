using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MP3Editor.Businesslogic.Filetypes.ID3V1;

namespace MP3Editor.Businesslogic.Test
{
    [TestClass]
    public class Id3V1
    {
        [TestMethod]
        public void ReadFile()
        {
            
            string filepath = "Give Me The Night.mp3";
            var reader = new Mock<IFileTypeReader>();
            var id3v1file = new Mock<IID3V1>();
            id3v1file.Setup(i => i.Filename)
                .Returns(filepath);

            reader
                .Setup(r => r.Read(filepath))
                .Returns(id3v1file.Object);

            IID3V1 file = (IID3V1)reader.Object.Read(filepath);
            Assert.AreEqual(file.Filename, filepath);
        }

        [TestMethod]
        public void WriteFile()
        {
        }

    }
}
