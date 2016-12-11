using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Language
{
    /// <summary>
    /// Represents one Language
    /// </summary>
    public class Language
    {
        private CultureInfo cultureInfo;
        /// <summary>
        /// Initializes the language
        /// </summary>
        /// <param name="cultureInfo">The culture info of the language</param>
        public Language(CultureInfo cultureInfo)
        {
            this.cultureInfo = cultureInfo;
        }

        /// <summary>
        /// Returns the name of the language
        /// </summary>
        public string Name
        {
            get { return cultureInfo.DisplayName; }
        }

        /// <summary>
        /// Returns the short, 3 letters name of the language
        /// </summary>
        public string Shortname
        {
            get { return cultureInfo.ThreeLetterISOLanguageName; }
        }
    }
}
