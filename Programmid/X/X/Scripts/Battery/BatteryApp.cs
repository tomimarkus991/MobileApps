using Android.App;
using Android.OS;
using Android.Widget;
using Xamarin.Essentials;

namespace X
{
    [Activity(Label = "BatteryApp")]
    public class BatteryApp : Activity
    {
        TextView _batteryState;
        TextView _batteryChargeSource;
        TextView _batteryChargeLevel;

        ImageView _batteryImage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.batteryApp);
            //Create your application here
            var level = Battery.ChargeLevel;
            _batteryChargeLevel.Text = level.ToString();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;

            _batteryState = FindViewById<TextView>(Resource.Id.batteryState);
            _batteryChargeSource = FindViewById<TextView>(Resource.Id.batteryChargeSource);
            _batteryChargeLevel = FindViewById<TextView>(Resource.Id.batteryChargeLevel);
            _batteryImage = FindViewById<ImageView>(Resource.Id.imageView1);

            var state = Battery.State;
            
            switch (state)
            {
                case BatteryState.Charging:
                    _batteryState.Text = "Charging";
                    int chargingBatteryInt = Resource.Drawable.batteryCharging;
                    _batteryImage.SetImageResource(chargingBatteryInt);
                    break;
                case BatteryState.Full:
                    _batteryState.Text = "Full";
                    int fullBatteryInt = Resource.Drawable.battery100;
                    _batteryImage.SetImageResource(fullBatteryInt);
                    break;
                case BatteryState.Unknown:
                    _batteryState.Text = "Unable to detect battery state";
                    break;
            }

            var source = Battery.PowerSource;

            switch (source)
            {
                case BatteryPowerSource.Battery:
                    _batteryChargeSource.Text = "Being powered by the battery";
                    break;
                case BatteryPowerSource.AC:
                    _batteryChargeSource.Text = "Being powered by A/C unit";
                    break;
                case BatteryPowerSource.Usb:
                    _batteryChargeSource.Text = "Being powered by USB cable";
                    break;
                case BatteryPowerSource.Wireless:
                    _batteryChargeSource.Text = "Powered via wireless charging";
                    break;
                case BatteryPowerSource.Unknown:
                    _batteryChargeSource.Text = "Unable to detect power source";
                    break;
            }
        }
        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            //var state = e.State;
            //var source = e.PowerSource;
            //var level = e.ChargeLevel;

            //_batteryState.Text = state.ToString();
            //_batteryChargeSource.Text = source.ToString();
            //_batteryChargeLevel.Text = level.ToString();



            

            //if (level >= 90)
            //{
            //    int fullBatteryInt = Resource.Drawable.battery100;
            //    //_batteryImage.SetImageDrawable(Resource.Drawable.battery100);
            //    _batteryImage.SetImageResource(fullBatteryInt);
            //}

        }
    }
}