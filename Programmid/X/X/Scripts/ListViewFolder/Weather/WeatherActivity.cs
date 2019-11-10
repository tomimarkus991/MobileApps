using Android.App;
using Android.OS;
using Android.Widget;
using System;
using WeatherApi.Core;
using Xamarin.Essentials;

namespace X.Scripts.ListViewFolder.Weather
{
    [Activity(Label = "listActivity")]
    public class WeatherActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.weather_main_layout);

            var searchField = FindViewById<EditText>(Resource.Id.searchEditText);
            var searchButton = FindViewById<Button>(Resource.Id.searchButton);
            var weatherListView = FindViewById<ListView>(Resource.Id.list);

            ShakeButtonClick();

            searchButton.Click += async delegate
            {
                string cityName = searchField.Text; // võtab searchtexti selleks milleks kasutaja sisestas
                string cityNameString = "https://www.metaweather.com/api/location/search/?query=" + cityName;

                var woeid2 = await DataService.GetDataFromLocation(cityNameString);

                string searchWoeid = woeid2[0].Woeid.ToString();

                string queryString = "https://www.metaweather.com/api/location/" + searchWoeid;
                var data = await DataService.GetDataFromService(queryString);
                weatherListView.Adapter = new WeatherAdapter(this, data.Consolidated_weather);
            };
        }
        public void ShakeButtonClick()
        {
            Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;
            Accelerometer.Start(SensorSpeed.Game);
        }
        public void Accelerometer_ShakeDetected(object sender, EventArgs e) // Here's what shaking does
        {
            var searchButton = FindViewById<Button>(Resource.Id.searchButton);
            searchButton.PerformClick();
        }
    }
}