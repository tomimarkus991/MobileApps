using CopyGram.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CopyGram
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PostsView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
