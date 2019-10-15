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

namespace X.Scripts.ListViewFolder.Car
{
    [Activity(Label = "CarAcitivity")]
    public class CarAcitivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.car_layout);

            var list = FindViewById<ListView>(Resource.Id.listView1);

            var _items = new List<CarInfo>()
            {
                new CarInfo(){Manufacturer = "Fiat", Model = "12C", ReleaseYear = "4m/s", HP = "4000"},
                new CarInfo(){Manufacturer = "Nissan", Model = "12C", ReleaseYear = "4m/s", HP = "4000"},
                new CarInfo(){Manufacturer = "Subaru", Model = "12C", ReleaseYear = "4m/s", HP = "4000"},
                new CarInfo(){Manufacturer = "Lexus", Model = "12C", ReleaseYear = "4m/s", HP = "4000"},
                new CarInfo(){Manufacturer = "Toyota", Model = "12C", ReleaseYear = "4m/s", HP = "4000"},
                new CarInfo(){Manufacturer = "Chervolet", Model = "12C", ReleaseYear = "4m/s", HP = "4000"},
                new CarInfo(){Manufacturer = "Tesla", Model = "12C", ReleaseYear = "4m/s", HP = "4000"},
                new CarInfo(){Manufacturer = "Renault", Model = "12C", ReleaseYear = "4m/s", HP = "4000"},
                new CarInfo(){Manufacturer = "Ford", Model = "12C", ReleaseYear = "1990", HP = "4000"}
            };

            list.Adapter = new CarAdapter(this, _items);
        }
    }
}