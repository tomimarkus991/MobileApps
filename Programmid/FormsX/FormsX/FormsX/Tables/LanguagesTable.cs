using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FormsX.Tables
{
    public class LanguagesTable
    {
        public ObservableCollection<Language1> Languages1 { get; set; }
        public LanguagesTable()
        {
            new Language1() { LanguageLong = "Eesti", LanguageShort = "Est" };
            new Language1() { LanguageLong = "English", LanguageShort = "En" };
            new Language1() { LanguageLong = "Deutsch", LanguageShort = "De" };
        }
        public class Language1
        {
            public string LanguageLong { get; set; }
            public string LanguageShort { get; set; }
        }
    }
}
