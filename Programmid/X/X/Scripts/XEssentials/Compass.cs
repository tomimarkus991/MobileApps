//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Xamarin.Essentials;

//namespace X.Scripts.XEssentials
//{
//    [Activity(Label = "Compass")]
//    public class Compass : Activity
//    {
//        protected override void OnCreate(Bundle savedInstanceState)
//        {
//            base.OnCreate(savedInstanceState);

//            // Create your application here
//            SetContentView(Resource.Layout.layout_compass);
//            Xamarin.Essentials.Platform.Init(this, savedInstanceState);



//        }

//        public class CompassTest
//        {
//            // Set speed delay for monitoring changes.
//            SensorSpeed speed = SensorSpeed.UI;

//            public CompassTest()
//            {
//                // Register for reading changes, be sure to unsubscribe when finished
//                Compass.ReadingChanged += Compass_ReadingChanged;
//            }

//            void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
//            {
//                var data = e.Reading;
//                Console.WriteLine($"Reading: {data.HeadingMagneticNorth} degrees");
//                // Process Heading Magnetic North
//            }

//            public void ToggleCompass()
//            {
//                try
//                {
//                    if (Compass.IsMonitoring)
//                    {
//                        Compass.Stop();
//                    }
//                    else
//                    {
//                        Compass.Start(speed);
//                        //Compass.Start(SensorSpeed.UI, applyLowPassFilter: true);
//                    }
//                }
//                catch (FeatureNotSupportedException fnsEx)
//                {
//                    // Feature not supported on device
//                }
//                catch (Exception ex)
//                {
//                    // Some other exception has occurred
//                }
//            }
//        }
//    }
//}