using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Apps
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        Button _homeButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.challenge1);

            // Create your application here

            _homeButton = FindViewById<Button>(Resource.Id.button1);

            _homeButton.Click += HomeButton_Click;
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.activity_main);
            Toast.MakeText(this, "texttst", ToastLength.Short).Show();
        }
    }
}