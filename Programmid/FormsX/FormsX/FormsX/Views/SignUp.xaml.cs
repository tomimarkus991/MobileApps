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
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulations", "User Registration Successful", "Yes", "Cancel");
            });
        }
    }
}