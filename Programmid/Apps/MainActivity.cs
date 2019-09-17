using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace Apps
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button _scene1;
        Button _scene2;
        Button _scene3;
        Button _scene4;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // Code

            _scene1 = FindViewById<Button>(Resource.Id.scene1);
            _scene2 = FindViewById<Button>(Resource.Id.scene2);
            _scene3 = FindViewById<Button>(Resource.Id.scene3);
            _scene4 = FindViewById<Button>(Resource.Id.scene4);

            _scene1.Click += Scene1_Click;
            _scene2.Click += Scene2_Click;
            _scene3.Click += Scene3_Click;
            _scene4.Click += Scene4_Click;
        }
        private void Scene1_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Activity1));
            this.StartActivity(intent);
        }
        private void Scene2_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Activity2));
            this.StartActivity(intent);
        }
        private void Scene3_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Activity3));
            this.StartActivity(intent);
        }
        private void Scene4_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Activity4));
            this.StartActivity(intent);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}