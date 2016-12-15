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
        /// Parse the content of a m3u files
        /// </summary>
        /// <param name="content">The content of the files</param>
        /// <returns>The content as files list</returns>
        public List<File> ParseFile(string[] content)
        {
            return content.Where(line => !line.StartsWith("#"))
                .Select(line => new File(line))
                .ToList();
        }

        /// <summary>
        /// Loads the Files of the Playlist
        /// </summary>
        public void Load(string path)
        {
            files = ParseFile(System.IO.File.ReadAllLines(path));
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
        /// Returns the text, which can be saved as M3U file
        /// </summary>
        public string M3UText
        {
            get
            {
                string text = string.Format("#EXTM3U{0}", Environment.NewLine);
                foreach (File file in this.files)
                {
                    text = string.Format("{0}{1}{2}", text, file.FilePath, Environment.NewLine);
                }
                return text;
            }
        }

        /// <summary>
        /// Saves the playlist
        /// </summary>
        /// <param name="path">The name to save the m3u file to</param>
        public void Save(string path)
        {
            System.IO.File.WriteAllText(path, M3UText);
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
