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
            var reader = new Mock<IFileTypeReader>();
            
            string filepath = "Give Me The Night.mp3";

            reader
                .Setup(r => r.Read(filepath))
                .Returns(new Filetypes.ID3V1.Id3V1() {Filename = filepath});
            
            Filetypes.ID3V1.Id3V1 file = (Filetypes.ID3V1.Id3V1)reader.Object.Read(filepath);
            Assert.AreEqual(file.Filename, filepath);
        }

    }
}
