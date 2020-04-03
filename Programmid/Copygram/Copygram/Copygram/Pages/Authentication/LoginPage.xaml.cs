using Copygram.Models;
using Copygram.Tabs;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Copygram.Pages.Authentication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
        private void Login_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbPath);
            var myQuery = db.Table<User>().Where(u => u.Email.Equals(EntryEmail.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if (myQuery != null)
            {
                App.Current.MainPage = new NavigationPage(new TabbedPage1());
            }
            else
            {
                Device.BeginInvokeOnMainThread( () =>
                {
                    DisplayAlert("Error", "Username or Password wrong", "ok");
                });
            }
        }
    }
}