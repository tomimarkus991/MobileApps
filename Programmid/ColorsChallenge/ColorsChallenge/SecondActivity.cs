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

namespace ColorsChallenge
{
    [Activity(Label = "SecondActivity")]
    class SecondActivity : Activity
    {
        Button _scene1;
        Button _scene2;
        Button _scene3;
        Button _scene4;
        protected override void OnCreate(Bundle savedInstanceState) // Main function
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_second);

            // Code

            _scene1 = FindViewById<Button>(Resource.Id.scene1);
            _scene2 = FindViewById<Button>(Resource.Id.scene2);
            _scene3 = FindViewById<Button>(Resource.Id.scene3);
            _scene4 = FindViewById<Button>(Resource.Id.scene4);

            _scene1.Click += _scene1_Click;
            
        }

        private void _scene1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}