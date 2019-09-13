using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace ColorChallenge
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button _scene1;
            Button _scene2;
            Button _scene3;
            Button _scene4;

            // Code
            
            _scene1 = FindViewById<Button>(Resource.Id.scene1);
            _scene2 = FindViewById<Button>(Resource.Id.scene2);
            _scene3 = FindViewById<Button>(Resource.Id.scene3);
            _scene4 = FindViewById<Button>(Resource.Id.scene4);

            _scene1.Click += _scene1_Click;
            _scene2.Click += _scene2_Click;
            _scene3.Click += _scene3_Click;
            _scene4.Click += _scene4_Click;
        }
        private void _scene1_Click(object sender, EventArgs e)
        {
                SetContentView(Resource.Layout.challenge1);
        }
        private void _scene2_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.challenge2);
        }
        private void _scene3_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.challenge3);
        }
        private void _scene4_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.challenge4);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}