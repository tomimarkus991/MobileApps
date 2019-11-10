using Android.App;
using Android.OS;

namespace X
{
    [Activity(Label = "RelativeChallenge2")]
    public class RelativeChallenge2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout2_relative);
            // Create your application here
        }
    }
}