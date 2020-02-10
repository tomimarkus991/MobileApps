using FormsX.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void Register_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<SignUpUserTable>();

            var item = new SignUpUserTable()
            {
                UserName = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text
            };
            db.Insert(item);
            if (item.UserName == null)
            {
                DisplayAlert("Alert", "please enter Username", "ok");
            }
            else if (item.Password == null)
            {
                DisplayAlert("Alert", "please enter Password", "ok");
            }
            else if (item.Email == null)
            {
                DisplayAlert("Alert", "please enter Email", "ok");
            }
            if (item.UserName != null && item.Password != null && item.Email != null)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Registration Complete", "User Registration Successful", "Yes", "Cancel");
                    if (result)
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }
                });
            }
        }
    }
}