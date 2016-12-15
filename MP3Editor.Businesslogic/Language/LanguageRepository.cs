using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Editor.Businesslogic.Language
{
    /// <summary>
    /// The language factory
    /// </summary>
    public static class LanguageRepository
    {
        private static List<Language> languages = new List<Language>();

        private static void LoadLanguages()
        {
            languages = CultureInfo
               .GetCultures(CultureTypes.NeutralCultures)
               .Select(c => new Language(c))
               .ToList();
        }
        /// <summary>
        /// Gets all Languages by ISO-6392
        /// </summary>
        /// <returns>A list of Languages</returns>
        public static List<Language> GetAll()
        {
            if (languages.Count == 0)
            {
                LoadLanguages();
            }
            return languages;
        }

        /// <summary>
        /// Get Language by its 3 Letter shortname
        /// </summary>
        /// <param name="shortname">The 3 letter ISO-6392 shortname</param>
        /// <returns>The desired language</returns>
        public static Language GetByShortname(string shortname)
        {
            if (languages.Count == 0)
            {
                LoadLanguages();
            }
            return languages.FirstOrDefault(c => c.Shortname == shortname);
        }

        /// <summary>
        /// Clear the stored languages
        /// </summary>
        public static void Clear()
        {
            languages.Clear();
        }
    }
}
