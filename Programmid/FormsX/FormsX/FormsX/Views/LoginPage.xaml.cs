﻿using FormsX.Tables;
using SQLite;
using System;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsX.Views
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
            await Navigation.PushAsync(new SignUp());
        }
        private void Login_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbPath);
            var myQuery = db.Table<SignUpUserTable>().Where(u => u.UserName.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if (myQuery != null)
            {
                App.Current.MainPage = new NavigationPage(new TabbedPage1());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Username or Password wrong", "Yes", "Cancel");
                    if (result)
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }
                    else
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }
                });
            }
            //await Navigation.PushAsync(new HomeScreen());
        }
    }
}