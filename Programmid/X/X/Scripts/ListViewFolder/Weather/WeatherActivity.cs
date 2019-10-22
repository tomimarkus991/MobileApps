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
using Api.Core;

namespace X.Scripts
{
    [Activity(Label = "listActivity")]
    public class WeatherActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var queryString = "https://www.metaweather.com/api/location/search/?query=london";
            var data = DataService.GetDataService(queryString);

            //var items = new List<WeatherInfo>()
            //{
            //    new WeatherInfo(){Name = "Esmaspäev", Temperature = "12C", WindSpeed = "4m/s"},
            //    new WeatherInfo(){Name = "Teisipäev", Temperature = "13C", WindSpeed = "5m/s"},
            //    new WeatherInfo(){Name = "Kolmapäev", Temperature = "14C", WindSpeed = "6m/s"}
            //};

            //ListAdapter = new BasicAdapter(this, items);

            var items = new List<WeatherID.ConsolidatedWeather>()
            {
                new WeatherID.ConsolidatedWeather(){Id = WeatherID.ConsolidatedWeather, }
            };

            ListAdapter = new BasicAdapter(this, items);


            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };
        }
    }
}