using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Genre
{
    /// <summary>
    /// The factory to produce Genres
    /// </summary>
    public class GenreRepository
    {
        /// <summary>
        /// Returns all Genre Options
        /// </summary>
        /// <returns>Genre List of possible Genres options for Audio Files</returns>
        public List<Genre> GetAllAudioGenres()
        {
            List<Genre> genres = new List<Genre>();
            foreach (string genre in TagLib.Genres.Audio)
            {
                genres.Add(new Genre(genre));
            }
            return genres;
        }
    }
}
