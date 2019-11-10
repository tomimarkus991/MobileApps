using Android.App;
using Android.OS;

namespace X
{
    [Activity(Label = "LinearChallenge2")]
    public class LinearChallenge2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout2_linear);
            // Create your application here
        }
    }
}