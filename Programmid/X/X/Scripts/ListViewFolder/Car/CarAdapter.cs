using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace X.Scripts.ListViewFolder.Car
{
    class CarAdapter : BaseAdapter<CarInfo>
    {

        List<CarInfo> _items;
        Activity _context;
        public CarAdapter(Activity context, List<CarInfo> items) : base()
        {
            _items = items;
            _context = context;
        }

        public override CarInfo this[int position]
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
                view = _context.LayoutInflater.Inflate(Resource.Layout.car_layout, null);
            }
            view.FindViewById<TextView>(Resource.Id.textViewManufacturer).Text = item.Manufacturer;
            view.FindViewById<TextView>(Resource.Id.textViewModel).Text = item.Model;
            view.FindViewById<TextView>(Resource.Id.textViewReleaseYear).Text = item.ReleaseYear;
            view.FindViewById<TextView>(Resource.Id.textViewHP).Text = item.HP;
            return view;
        }
    }
}