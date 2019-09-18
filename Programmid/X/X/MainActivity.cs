using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace X
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        // Calculator
        Button _calcButton;

        // Linear Layout Challenge
        Button _linearButton1;
        Button _linearButton2;
        Button _linearButton3;
        Button _linearButton4;

        // Relative Layout Challenge
        Button _relativeButton1;
        Button _relativeButton2;
        Button _relativeButton3;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // ühendame nupuga
            _calcButton = FindViewById<Button>(Resource.Id.calcButton);

            _linearButton1 = FindViewById<Button>(Resource.Id.linearButton1);
            _linearButton2 = FindViewById<Button>(Resource.Id.linearButton2);
            _linearButton3 = FindViewById<Button>(Resource.Id.linearButton3);
            _linearButton4 = FindViewById<Button>(Resource.Id.linearButton4);

            _relativeButton1 = FindViewById<Button>(Resource.Id.relativeButton1);
            _relativeButton2 = FindViewById<Button>(Resource.Id.relativeButton2);
            _relativeButton3 = FindViewById<Button>(Resource.Id.relativeButton3);

            // ühendame Click eventi meetodiga

            _calcButton.Click += CalcButton_Click;

            _linearButton1.Click += LinearButton1_Click;
            _linearButton2.Click += LinearButton2_Click;
            _linearButton3.Click += LinearButton3_Click;
            _linearButton4.Click += LinearButton4_Click;

            _relativeButton1.Click += RelativeButton1_Click;
            _relativeButton2.Click += RelativeButton2_Click;
            _relativeButton3.Click += RelativeButton3_Click;
        }
        private void CalcButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(CalculatorChallenge));
            this.StartActivity(intent);
        }
        private void LinearButton1_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(LinearChallenge1));
            this.StartActivity(intent);
        }
        private void LinearButton2_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(LinearChallenge2));
            this.StartActivity(intent);
        }
        private void LinearButton3_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(LinearChallenge3));
            this.StartActivity(intent);
        }
        private void LinearButton4_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(LinearChallenge4));
            this.StartActivity(intent);
        }
        private void RelativeButton1_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(RelativeChallenge1));
            this.StartActivity(intent);
        }
        private void RelativeButton2_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(RelativeChallenge2));
            this.StartActivity(intent);
        }
        private void RelativeButton3_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(RelativeChallenge3));
            this.StartActivity(intent);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}