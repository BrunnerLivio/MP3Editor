using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Playlist
{
    /// <summary>
    /// Represents one M3U playlist
    /// </summary>
    public class Playlist
    {
        private string path;
        private List<File> files;
        
        /// <summary>
        /// Initializes the playlist
        /// </summary>
        /// <param name="path">The path of the m3u file</param>
        public Playlist(string path)
        {
            if (!this.path.EndsWith(".m3u"))
            {
                throw new Exception("Is not M3U file");
            }
            this.path = path;
        }

        /// <summary>
        /// Loads the Files of the Playlist
        /// </summary>
        public void Load()
        {
            files = System.IO.File.ReadAllLines(path)
                .Where(line =>
                    !line.StartsWith("#")
                    && System.IO.File.Exists(line))
                .Select(line => new File(line))
                .ToList();
        }

        /// <summary>
        /// Returns the files of the playlist. 
        /// Loads them, if they are not loaded
        /// </summary>
        public List<File> Files
        {
            get
            {
                if (this.files.Count == 0)
                {
                    Load();
                }
                return this.files;
            }
        }
    }
}
