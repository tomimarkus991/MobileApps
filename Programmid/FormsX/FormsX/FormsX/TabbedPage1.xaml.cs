﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsX
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
        }
        //await Navigation.PushAsync(new ListViewPage1());
        //private async void Languages_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new ListViewPage1());
        //}
    }
}