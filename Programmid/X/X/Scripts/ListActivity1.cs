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

namespace X.Scripts
{
    [Activity(Label = "listActivity")]
    public class ListActivity1 : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var items = new List<WeatherInfo>()
            {
                new WeatherInfo(){Name = "Esmaspäev", Temperature = "12C", WindSpeed = "4m/s"},
                new WeatherInfo(){Name = "Teisipäev", Temperature = "13C", WindSpeed = "5m/s"},
                new WeatherInfo(){Name = "Kolmapäev", Temperature = "14C", WindSpeed = "6m/s"}
            };

            ListAdapter = new BasicAdapter(this, items);


            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };
        }
    }
}