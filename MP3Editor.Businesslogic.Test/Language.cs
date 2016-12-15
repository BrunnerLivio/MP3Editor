using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP3Editor.Businesslogic.Language;

namespace MP3Editor.Businesslogic.Test
{
    [TestClass]
    public class Language
    {
        [TestMethod]
        public void LanguageProperties()
        {
            Businesslogic.Language.Language language = new Businesslogic.Language.Language(new CultureInfo("en-US"));
            Assert.AreEqual("eng", language.Shortname);
            Assert.AreEqual("Englisch (USA)", language.Name);
        }

        [TestMethod]
        public void LanguageRepositoryGetAll()
        {
            LanguageRepository.Clear();
            int cultureCount = CultureInfo
                .GetCultures(CultureTypes.NeutralCultures).Length;
            List<Businesslogic.Language.Language> languages = LanguageRepository.GetAll();

            Assert.AreEqual(languages.Count, cultureCount);
        }

        [TestMethod]
        public void LanguageRepositoryGetByShortname()
        {
            LanguageRepository.Clear();
            CultureInfo lastCulture = CultureInfo
                .GetCultures(CultureTypes.NeutralCultures).Skip(1).First();
            Businesslogic.Language.Language language = LanguageRepository.GetByShortname(lastCulture.ThreeLetterISOLanguageName);

            Assert.AreEqual(lastCulture.ThreeLetterISOLanguageName, language.Shortname);
            Assert.AreEqual(lastCulture.DisplayName, language.Name);
        }

    }
}
