using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Playlist
{
    /// <summary>
    /// Represents one M3U playlist
    /// </summary>
    public class Playlist
    {
        private List<File> files = new List<File>();
        
        /// <summary>
        /// Loads the Files of the Playlist
        /// </summary>
        public void Load(string path)
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
                return this.files;
            }
        }

        /// <summary>
        /// Saves the playlist
        /// </summary>
        /// <param name="path">The name to save the m3u file to</param>
        public void Save(string path)
        {
            string text = "#EXTM3U\n";
            foreach (File file in this.files)
            {
                text = string.Format("{0}{1}\n", text, file.FilePath);
                System.IO.File.WriteAllText(path, text);
            }
        }

        /// <summary>
        /// Add a file to this playlist
        /// </summary>
        /// <param name="filepath">The path of the file to add</param>
        public void Add(string filepath)
        {
            Files.Add(new File(filepath));
        }
    }
}
