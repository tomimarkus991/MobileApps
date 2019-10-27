using Android.App;
using Android.OS;
using Api.Core;

namespace X.Scripts.ListViewFolder.Weather
{
    [Activity(Label = "listActivity")]
    public class WeatherActivity : ListActivity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var queryString = "https://www.metaweather.com/api/location/44418/";

            var data = await Api.Core.DataService.GetDataFromService(queryString);

            var weather = data as WeatherID.ConsolidatedWeather;

            ListAdapter = new WeatherAdapter(this, weather.Consolidated_weather);
        }
    }
}