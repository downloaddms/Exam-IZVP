using System.Collections.Generic;
using System.Linq;

namespace Exam_IZVP.Core
{
    public static class LanguageManager
    {
        private static List<string> _allLanguages = new List<string>
        {
            "C#", "Java", "Python", "JavaScript", "C++"
        };

        public static List<string> GetAllLanguages() => _allLanguages;

        public static void AddLanguage(string language)
        {
            if (!_allLanguages.Contains(language))
                _allLanguages.Add(language);
        }
    }
}