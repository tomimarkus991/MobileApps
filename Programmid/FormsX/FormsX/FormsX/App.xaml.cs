﻿using FormsX.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsX
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new TabbedPage1());
            MainPage = new NavigationPage(new LoginPage());
            //MainPage = new MainPage();
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
