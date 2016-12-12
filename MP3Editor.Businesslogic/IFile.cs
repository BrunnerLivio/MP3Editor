using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic
{
    /// <summary>
    /// Represnts a file
    /// </summary>
    public interface IFile
    {
        /// <summary>
        /// The absoulte path, where the file is located
        /// </summary>
        string FilePath { get; }
    }
}
