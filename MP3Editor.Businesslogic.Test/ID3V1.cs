using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP3Editor.Businesslogic.Filetypes.ID3V1;

namespace MP3Editor.Businesslogic.Test
{
    [TestClass]
    public class Id3V1
    {
        [TestMethod]
        public void ReadFile()
        {
            FileTypeContext context = new FileTypeContext();
            context.SetFileTypeReader(new Id3V1Reader());
            string filepath = @"C:\Users\yungmushi\GDrive\Musik\DJ\Songs\Chill\Obvs.flac";
            Filetypes.ID3V1.Id3V1 file = (Filetypes.ID3V1.Id3V1)context.Read(filepath);
            Assert.AreEqual(file.Filename, filepath);
        }
    }
}
