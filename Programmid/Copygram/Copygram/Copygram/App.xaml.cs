using Copygram.Data;
using Copygram.Pages;
using Copygram.Tabs;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Copygram
{
    public partial class App : Application
    {
        static ApplicationDatabase _dbContext;
        public static ApplicationDatabase dbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = new ApplicationDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Posts.db3"));
                }
                return _dbContext;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            //MainPage = new NavigationPage(TabbedPage1());
            //MainPage = new TabbedPage1();
            //MainPage = new NavigationPage(Copygram.Tabs.TabbedPage1);
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
