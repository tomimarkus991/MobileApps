using Copygram.Models;
using Copygram.Pages.Authentication;
using Plugin.Media;
using SQLite;
using System;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Copygram.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            var user = (User)BindingContext;
            EnterUsername.Text = user.Username;
        }
        private async void TakeProfilePicture_Clicked(object sender, EventArgs e)
        {
            var photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                ProfilePhoto.Source = photo.Path;
        }
        private async void SaveProfile_Clicked(object sender, EventArgs e)
        {
            var user = (User)BindingContext;
            if (EnterUsername.Text != "" && ProfilePhoto.Source != null)
            {
                string currentPath = ProfilePhoto.Source.ToString();
                string formattedPath = currentPath.Substring(6);
                user.Username = EnterUsername.Text.ToString();
                user.ProfilePhotoPath = formattedPath;
                Username.Text = EnterUsername.Text.ToString();

                await App.dbContext.SaveUserAsync(user);
                await DisplayAlert("Success", "Update Complete", "Yesss!");
            }
            else
            {
                await DisplayAlert("Error", "Empty shit", "ok");
            }
        }
        private async void Logout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}