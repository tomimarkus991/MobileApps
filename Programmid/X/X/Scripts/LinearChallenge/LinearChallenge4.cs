using Android.App;
using Android.OS;

namespace X
{
    [Activity(Label = "LinearChallenge4")]
    public class LinearChallenge4 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout4_linear);
            // Create your application here
        }
    }
}