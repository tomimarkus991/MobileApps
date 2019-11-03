using Android.App;
using Android.Views;
using Android.Widget;
using Api.Core;
using System.Collections.Generic;

namespace X.Scripts
{
    class WeatherAdapter : BaseAdapter<Api.Core.WeatherInfo>
    {
        List<WeatherInfo> _items;
        Activity _context;
        public WeatherAdapter(Activity context, List<WeatherInfo> items) : base()
        {
            _items = items;
            _context = context;
        }
        public override WeatherInfo this[int position]
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
            int geenius = item.Woeid;
            view.FindViewById<TextView>(Resource.Id.textView1).Text = item.Consolidated_weather[position].Min_temp.ToString();
            view.FindViewById<TextView>(Resource.Id.textView1).Text = item.Woeid.ToString();
            //view.FindViewById<TextView>(Resource.Id.textView1).Text = Math.Round(item.Wind_speed.ToString(), 2);
            //view.FindViewById<TextView>(Resource.Id.textView2).Text = item.Weather_state_name;
            //view.FindViewById<TextView>(Resource.Id.textView3).Text = item.The_temp.ToString();
            return view;
        }
    }
}