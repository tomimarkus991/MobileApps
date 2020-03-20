using Copygram.Models;
using Copygram.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Copygram.Pages
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostsPage : ContentPage
    {
        public PostsPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //USE IF VIEWMODEL NOT WORK
            //Posts_ListView.ItemsSource = Task.Run(async () => await App.dbContext.GetPostsAsync()).Result;
            (this.BindingContext as PostsViewModel)?.RefreshList();
        }
        private async void Posts_ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new PostDetailsPage
                {
                    BindingContext = e.SelectedItem as Post,
                });
            }
        }
    }
}