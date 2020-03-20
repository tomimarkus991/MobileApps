using Copygram.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Copygram.ViewModels
{
    public class PostsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private ObservableCollection<Post> _posts;
        public ObservableCollection<Post> Posts
        {
            get
            {
                return _posts;
            }

            set
            {
                if (_posts != value)
                {
                    _posts = value;
                    OnPropertyChanged(nameof(Posts));
                }
            }

        }
        public PostsViewModel()
        {
            Posts = new ObservableCollection<Post>();
        }
        public void RefreshList()
        {
            Posts.Clear();
            List<Post> postList = Task.Run(async () => await App.dbContext.GetPostsAsync()).Result;

            foreach (Post post in postList)
            {
                Posts.Add(post);
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    Posts.Add(new Post()
            //    {
            //        Id = GetRandomId(),
            //        PictureUrl = "https://i.picsum.photos/id/" + GetRandomId() + "/500/360.jpg",
            //        Title = "GetRandomTitle()",
            //        Date = GetRandomDate()
            //    });
            //}
        }
        public DateTime GetRandomDate()
        {
            Random rnd = new Random();
            DateTime start = new DateTime(1995, 1, 1, 10, 40, 20);
            int range = (DateTime.UtcNow - start).Days;
            var date = start.AddDays(rnd.Next(range)).AddHours(rnd.Next(range));
            return date;
        }
        public int GetRandomId()
        {
            Random rnd = new Random();
            var id = rnd.Next(1, 400);
            return id;
        }
        //public string GetRandomTitle()
        //{
        //    //var fakeTitle = Faker.TextFaker.Sentence();
        //    //return fakeTitle;
        //}
    }
}
