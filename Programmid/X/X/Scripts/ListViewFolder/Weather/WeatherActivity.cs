using Android.App;
using Android.OS;
using Android.Widget;
using Api.Core;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace X.Scripts.ListViewFolder.Weather
{
    [Activity(Label = "listActivity")]
    public class WeatherActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //base.OnCreate(savedInstanceState);

            //var queryString = "https://www.metaweather.com/api/location/44418/";

            //var data = await Api.Core.DataService.GetDataFromService(queryString);

            //var weather = data as Weather;

            //ListAdapter = new WeatherAdapter(this, weather.Consolidated_weather);

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.weather_main_layout);

            var searchField = FindViewById<EditText>(Resource.Id.searchEditText);
            var searchButton = FindViewById<Button>(Resource.Id.searchButton);
            var weatherListView = FindViewById<ListView>(Resource.Id.list);

            searchButton.Click += async delegate
            {

                string cityName = searchField.Text; // võtab searchtexti selleks milleks kasutaja sisestas
                string cityNameString = "https://www.metaweather.com/api/location/search/?query=" + cityName;

                //LocationId location = new LocationId();
                //string woeidLocation = location.Woeid.ToString(); // saab woeid kätte ja muudab stringiks

                var woeid2 = await DataService.GetDataFromLocation(cityNameString);

                string searchWoeid = woeid2[0].Woeid.ToString();

                string queryString = "https://www.metaweather.com/api/location/" + searchWoeid;
                var data = await DataService.GetDataFromService(queryString);
                weatherListView.Adapter = new WeatherAdapter(this, data.Consolidated_weather);
            };
        }
    }
}