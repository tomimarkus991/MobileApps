using Android.App;
using Android.OS;

namespace X
{
    [Activity(Label = "RelativeChallenge1")]
    public class RelativeChallenge1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout1_relative);
            // Create your application here
        }
    }
}