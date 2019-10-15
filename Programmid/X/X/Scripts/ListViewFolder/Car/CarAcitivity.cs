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
                new CarInfo(){Manufacturer = "Fiat", Model = "biats", ReleaseYear = "9674", HP = "10000"},
                new CarInfo(){Manufacturer = "Nissan", Model = "Kaskai", ReleaseYear = "1236", HP = "5000"},
                new CarInfo(){Manufacturer = "Subaru", Model = "Jubanus", ReleaseYear = "8764", HP = "7000"},
                new CarInfo(){Manufacturer = "Lexus", Model = "Keksus", ReleaseYear = "5755", HP = "9000"},
                new CarInfo(){Manufacturer = "Toyota", Model = "Sojota", ReleaseYear = "323", HP = "2000"},
                new CarInfo(){Manufacturer = "Chervolet", Model = "Crocs", ReleaseYear = "1", HP = "1000"},
                new CarInfo(){Manufacturer = "Tesla", Model = "Broks", ReleaseYear = "32123", HP = "200"},
                new CarInfo(){Manufacturer = "Renault", Model = "Bešoo", ReleaseYear = "13219", HP = "12000"},
                new CarInfo(){Manufacturer = "Ford", Model = "shrek", ReleaseYear = "1990", HP = "200"},
                new CarInfo(){Manufacturer = "Audi", Model = "r6", ReleaseYear = "1990", HP = "60"}
            };

            list.Adapter = new CarAdapter(this, _items);
        }
    }
}