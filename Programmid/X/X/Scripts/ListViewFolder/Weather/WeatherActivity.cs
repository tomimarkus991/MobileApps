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
                LocationId location = new LocationId();
                var woeidLocation = location.Woeid.ToString(); // saab woeid kätte

                var woeid2 = await DataService.GetDataFromLocation(woeidLocation); // võtab data
                

                var searchText = searchField.Text; // paneb searchtexti selleks milleks kasutaja sisestas
                searchText = woeidLocation; // muudab selle woeidks

                var queryString = "https://www.metaweather.com/api/location/search/?query=" + searchText; // otsib seda woeid'd
                var data = await DataService.GetDataFromService(queryString);// võtab data
                weatherListView.Adapter = new WeatherAdapter(this, data.Results);
            };
        }
    }
}