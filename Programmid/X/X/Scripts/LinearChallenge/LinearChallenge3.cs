using Android.App;
using Android.OS;

namespace X
{
    [Activity(Label = "LinearChallenge3")]
    public class LinearChallenge3 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout3_linear);
            // Create your application here
        }
    }
}