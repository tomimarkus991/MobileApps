using Android.App;
using Android.OS;

namespace X
{
    [Activity(Label = "RelativeChallenge3")]
    public class RelativeChallenge3 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout3_relative);
            // Create your application here
        }
    }
}