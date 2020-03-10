using CopyGram.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CopyGram.ViewModels
{
    public class PostsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ObservableCollection<Post> Pictures { get; set; }

        public PostsViewModel()
        {
            Pictures = new ObservableCollection<Post>();
            for (int i = 0; i < 30; i++)
            {
                Random gen = new Random();
                DateTime start = new DateTime(1995, 1, 1, 10, 40, 20);
                int range = (DateTime.UtcNow - start).Days;
                var date = start.AddDays(gen.Next(range)).AddHours(gen.Next(range)).ToString();
                Random rnd = new Random();
                var id = rnd.Next(1, 400);
                var fakeTitle = Faker.Lorem.Sentence(2);
                Pictures.Add(new Post()
                {
                    PictureUrl = "https://i.picsum.photos/id/" + id + "/500/360.jpg",
                    Title = fakeTitle,
                    Date = date
                });
            }
        }
    }
}
