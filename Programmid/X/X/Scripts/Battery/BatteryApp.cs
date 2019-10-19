using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.batteryApp);
            // Create your application here

            _batteryState = FindViewById<TextView>(Resource.Id.batteryState);
            _batteryChargeSource = FindViewById<TextView>(Resource.Id.batteryChargeSource);
            _batteryChargeLevel = FindViewById<TextView>(Resource.Id.batteryChargeLevel);

            var state = Battery.State;           
            
            switch (state)
            {
                case BatteryState.Charging:
                    _batteryState.Text = "Charging";
                    break;
                case BatteryState.Full:
                    _batteryState.Text = "Full";
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

            var level = Battery.ChargeLevel;
            _batteryChargeLevel.Text = level.ToString();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }
        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            var state = e.State;
            var source = e.PowerSource;
            var level = e.ChargeLevel;

            _batteryState.Text = state.ToString();
            _batteryChargeSource.Text = source.ToString();
            _batteryChargeLevel.Text = level.ToString();
        }
    }
}