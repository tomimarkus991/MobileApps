using Android.App;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using WeatherApi.Core;

namespace X.Scripts
{
    class WeatherAdapter : BaseAdapter<ConsolidatedWeather>
    {
        List<ConsolidatedWeather> _items;
        Activity _context;
        public WeatherAdapter(Activity context, List<ConsolidatedWeather> items) : base()
        {
            _items = items;
            _context = context;
        }
        public override ConsolidatedWeather this[int position]
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
            view.FindViewById<TextView>(Resource.Id.dateView).Text = item.Applicable_date;
            view.FindViewById<TextView>(Resource.Id.textView1).Text = item.Weather_state_name;
            //view.FindViewById<TextView>(Resource.Id.tempView).Text = Math.Round(item.The_temp, 2).ToString() + " (℃)";
            //view.FindViewById<TextView>(Resource.Id.windSpeedView).Text = Math.Round(item.Wind_speed, 2).ToString() + " (m/s)";            
            return view;
        }
    }
}