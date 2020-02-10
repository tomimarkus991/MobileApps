using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            var names = new List<string>
            {
                "sadas", "kalle","peeter","aadam"
            };
            MainCarouselView.ItemsSource = names;
            //var pictures = new List<string>
            //{

            //};
            //MainCarouselView.ItemsSource = pictures;
        }
        private async void Logout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        private async void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }
    }
}