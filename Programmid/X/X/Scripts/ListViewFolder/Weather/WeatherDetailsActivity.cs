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
using Newtonsoft.Json;
using WeatherApi.Core;

namespace X.Scripts.ListViewFolder.Weather
{
    [Activity(Label = "WeatherDetailsActivity")]
    public class WeatherDetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.weather_click);
            // Create your application here
            var weatherDate = FindViewById<TextView>(Resource.Id.dateView);


            var weatherDetails = JsonConvert.DeserializeObject<ConsolidatedWeather>(Intent.GetStringExtra("weatherDetails"));
            //FindViewById<TextView>(Resource.Id.dateView).Text = weatherDetails.Applicable_date;
            weatherDate.Text = weatherDetails.Applicable_date;
        }
    }
}