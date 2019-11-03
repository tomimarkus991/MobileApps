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
    public class WeatherActivity : ListActivity
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
            var weatherListView = FindViewById<ListView>(Resource.Id.weatherListView);

            searchButton.Click += async delegate
            {
                List<Api.Core.WeatherInfo> _woe;
                var asi = _woe

                var searchText = searchField.Text;
                var queryString = "https://www.metaweather.com/api/location/search/?query=" + searchText;
                var data = await DataService.GetDataFromService(queryString);
                weatherListView.Adapter = new WeatherAdapter(this, data.Results);
            };
        }
    }
}