using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP3Editor.Businesslogic.Genre;

namespace MP3Editor.Businesslogic.Test
{
    [TestClass]
    public class GenreTest
    {
        [TestMethod]
        public void Create()
        {
            Genre.Genre genre = new Genre.Genre("myname");
            Assert.AreEqual("myname", genre.Name);
        }

        [TestMethod]
        public void GetAll()
        {
            GenreRepository repo =new GenreRepository();
            Assert.IsTrue(repo.GetAllAudioGenres().Count > 0);
        }
    }
}
