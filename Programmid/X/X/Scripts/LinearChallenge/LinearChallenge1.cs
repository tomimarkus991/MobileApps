using Android.App;
using Android.OS;

namespace X
{
    [Activity(Label = "LinearChallenge1")]
    public class LinearChallenge1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout1_linear);
            // Create your application here
        }
    }
}