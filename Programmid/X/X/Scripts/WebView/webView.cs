﻿//using Android.App;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Webkit;

//namespace X
//{
//    [Activity(Label = "WebView")]
//    public class WebView : Activity
//    {
//        WebView _webView;
//        protected override void OnCreate(Bundle savedInstanceState)
//        {
//            base.OnCreate(savedInstanceState);

//            // Create your application here
//            SetContentView(Resource.Layout.web_view);

//            var _webView = FindViewById<WebView>(Resource.Id.webView1);
//            _webView.Settings.JavaScriptEnabled = true;
//            _webView.SetWebViewClient(new XWebViewClient());
//            _webView.LoadUrl("https://www.neti.ee");
//        }
//        public override bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
//        {
//            if (keyCode == Keycode.Back && _webView.CanGoBack())
//            {
//                _webView.GoBack();
//                return true;
//            }
//            return base.OnKeyDown(keyCode, e);
//        }
//    }
//}