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

            var weatherDetails = JsonConvert.DeserializeObject<ConsolidatedWeather>(Intent.GetStringExtra("weatherDetails"));
            var weatherDetails2 = JsonConvert.DeserializeObject<MainWeather>(Intent.GetStringExtra("weatherDetails2"));

            FindViewById<TextView>(Resource.Id.humidity).Text = "Humidity " + weatherDetails.Humidity.ToString();
            FindViewById<TextView>(Resource.Id.airPressure).Text = "Air pressure " + weatherDetails.Air_pressure.ToString();
            FindViewById<TextView>(Resource.Id.visibility).Text = "Visibility " + Math.Round(weatherDetails.Visibility, 2).ToString();
            FindViewById<TextView>(Resource.Id.woeid).Text = "City's woeid " + weatherDetails2.Woeid.ToString();
            FindViewById<TextView>(Resource.Id.timezone).Text = weatherDetails2.Timezone;
            FindViewById<TextView>(Resource.Id.time).Text = Convert.ToDateTime(weatherDetails2.Time).ToString("dd/MMM H:mm");
            FindViewById<TextView>(Resource.Id.sunRise).Text = "Sun rise " + Convert.ToDateTime(weatherDetails2.Sun_rise).ToString("dd/MMM H:mm");
            FindViewById<TextView>(Resource.Id.sunSet).Text = "Sun set " + Convert.ToDateTime(weatherDetails2.Sun_set).ToString("dd/MMM H:mm");
            FindViewById<TextView>(Resource.Id.windDirection).Text = "Wind direction " + weatherDetails.Wind_direction_compass;
        }
    }
}