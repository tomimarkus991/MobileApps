using Android.App;
using Android.OS;
using Android.Widget;
using Api.Core;

namespace X.Scripts.ListViewFolder.Weather
{
    [Activity(Label = "listActivity")]
    public class WeatherActivity : ListActivity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //var queryString = "https://www.metaweather.com/api/location/44418/";

            //var data = await Api.Core.DataService.GetDataFromService(queryString);

            //var weather = data as WeatherID.ConsolidatedWeather;

            //ListAdapter = new WeatherAdapter(this, weather.Consolidated_weather);

            SetContentView(Resource.Layout.weather_main_layout);

            var searchField = FindViewById<EditText>(Resource.Id.searchEditText);
            var searchButton = FindViewById<Button>(Resource.Id.searchButton);
            var peopleListView = FindViewById<ListView>(Resource.Id.peopleListView);

            searchButton.Click += async delegate
            {
                var searchText = searchField.Text;
                var queryString = "https://www.metaweather.com/api/location/search/?query=" + searchText;
                var data = await DataService.GetDataFromService(queryString);
                peopleListView.Adapter = new WeatherAdapter(this, data.Results);
            };
        }
    }
}