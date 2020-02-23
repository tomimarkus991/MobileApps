using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace FormsX.ViewModels
{
    public class LanguageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ObservableCollection<Language> Languages { get; set; }
        public LanguageViewModel()
        {
            Languages = new ObservableCollection<Language>
            {
                new Language() { LanguageLong = "Eesti", LanguageShort = "Est" },
                new Language() { LanguageLong = "Eesti", LanguageShort = "Est" },
                new Language() { LanguageLong = "Eesti", LanguageShort = "Est" }
            };
        }
        public class Language
        {
            public string LanguageLong { get; set; }
            public string LanguageShort { get; set; }
        }

        //private List<string> _selectedLanguages;
        //public List<string> SelectedLanguages
        //{
        //    get { return _selectedLanguages; }
        //    set
        //    {
        //        if (_selectedLanguages != value)
        //        {
        //            _selectedLanguages = value;
        //            OnPropertyChanged(nameof(SelectedLanguages));
        //        }
        //    }
        //}
    }
}
