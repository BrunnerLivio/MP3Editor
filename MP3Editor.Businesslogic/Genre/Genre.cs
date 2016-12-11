using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Genre
{
    /// <summary>
    /// Represents one Genre
    /// </summary>
    public class Genre
    {
        private string name;
        /// <summary>
        /// Initializes the genre
        /// </summary>
        /// <param name="name">The name of the genre</param>
        public Genre(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Returns the name of the genre
        /// </summary>
        public string Name
        {
            get { return this.name; }
        }
    }
}
