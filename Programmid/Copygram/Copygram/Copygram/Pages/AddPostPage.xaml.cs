using Copygram.Models;
using Copygram.Pages;
using Copygram.Tabs;
using Plugin.Media;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Copygram
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPostPage : ContentPage
    {
        public AddPostPage()
        {
            InitializeComponent();
        }

        private async void TakePicture_Clicked(object sender, EventArgs e)
        {
            var photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                Image.Source = photo.Path;
        }

        private async void SavePost_Clicked(object sender, EventArgs e)
        {
            if (PostTitle.Text == "" && Image.Source.ToString() == "File: " 
                || PostTitle.Text == ""
                || Image.Source.ToString() == "File: ")
            {
                await DisplayAlert("dude", "Title and Picture are required!", "sorry mate");
            }
            else
            {
                var post = new Post();
                var user = (User)BindingContext;
                BindingContext = post;
                post.Title = PostTitle.Text;
                string currentPath = Image.Source.ToString();
                string formattedPath = currentPath.Substring(6);
                post.PictureUrl = formattedPath;
                post.Date = DateTime.Now;
                post.UserPhotoPath = user.ProfilePhotoPath;
                post.Username = user.Username;

                await App.dbContext.SavePostAsync(post);
                await Navigation.PopAsync();
                await Navigation.PushAsync(new TabbedPage1());
                PostTitle.Text = "";
                Image.Source = "";
            }
        }
    }
}