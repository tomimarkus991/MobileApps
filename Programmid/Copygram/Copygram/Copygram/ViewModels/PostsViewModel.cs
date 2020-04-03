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
        }
    }
}
