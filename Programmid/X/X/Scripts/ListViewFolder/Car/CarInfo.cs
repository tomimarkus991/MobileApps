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
    class CarInfo
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string ReleaseYear { get; set; }
        public string HP { get; set; }
    }
}