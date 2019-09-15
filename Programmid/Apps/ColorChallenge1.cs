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
    [Activity(Label = "ColorChallenge1")]
    public class ColorChallenge1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            //SetContentView(Resource.Layout.challenge1);

            //Button _homeButton;

            //_homeButton = FindViewById<Button>(Resource.Id.homeButton);

            //_homeButton.Click += _homeButton_Click;

            //    Button _button1;

            //    _button1 = FindViewById<Button>(Resource.Id.homeButton);

            //    _button1.Click += _button1_Click;
        }
        //private void _button1_Click(object sender, EventArgs e)
        //{
        //    //SetContentView(Resource.Layout.activity_main);
        //    SetContentView(Resource.Layout.challenge2);
        //}
        //public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        //{
        //    Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        //}
    }
}