using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace FormsX.ViewModels
{
    class PicturesIGViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ObservableCollection<Picture> Pictures { get; set; }
        public PicturesIGViewModel()
        {
            Pictures = new ObservableCollection<Picture>
            {
                new Picture() { PictureUrl = "Resources", Title = "Minu pilt 1", Date = "20.08.2017" },
                new Picture() { PictureUrl = "test.png", Title = "Minu pilt 2", Date = "20.08.2018" },
                new Picture() { PictureUrl = "test.png", Title = "Minu pilt 3", Date = "20.08.2019" }
            };
        }
        public class Picture
        {
            public string PictureUrl { get; set; }
            public string Title { get; set; }
            public string Date { get; set; }
        }
    }
}
