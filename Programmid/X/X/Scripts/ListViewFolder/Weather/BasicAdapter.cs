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
    class BasicAdapter : BaseAdapter<WeatherID.ConsolidatedWeather>
    {
        List<WeatherID.ConsolidatedWeather> _items;
        Activity _context;
        public BasicAdapter(Activity context, List<WeatherID.ConsolidatedWeather> items) : base()
        {
            _items = items;
            _context = context;
        }
        public override WeatherID.ConsolidatedWeather this[int position]
        {
            get { return _items[position]; }
        }
        public override int Count
        {
            get { return _items.Count; }
        }
        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];
            View view = convertView;
            if (view == null)
            {
                view = _context.LayoutInflater.Inflate(Resource.Layout.weather_row, null);
            }
            view.FindViewById<TextView>(Resource.Id.textView1).Text = item.Id.ToString();
            view.FindViewById<TextView>(Resource.Id.textView2).Text = item.Weather_state_name;
            view.FindViewById<TextView>(Resource.Id.textView3).Text = item.The_temp.ToString();
            return view;
        }
    }
}