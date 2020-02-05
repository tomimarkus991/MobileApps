﻿using SignIn.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignIn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RegistrationPage();
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
