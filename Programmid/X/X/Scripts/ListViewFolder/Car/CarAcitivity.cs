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

            Random rnd = new Random();
            var _items = new List<CarInfo>();

            for (int i = 0; i < rnd.Next(40, 80); i++)
            {
                _items.Add(
                    new CarInfo()
                    {
                        Manufacturer = Faker.Name.Last(),
                        Model = Faker.Name.First(),
                        ReleaseYear = rnd.Next(1990, 2019).ToString(),
                        HP = rnd.Next(2000, 8000).ToString()
                    });
            }

            list.Adapter = new CarAdapter(this, _items);
        }
    }
}