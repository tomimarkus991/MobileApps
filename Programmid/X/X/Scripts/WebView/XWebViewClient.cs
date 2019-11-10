using Android.Webkit;

namespace X
{
    class XWebViewClient: WebViewClient
    {
        public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
        {
            view.LoadUrl(request.Url.ToString());
            return base.ShouldOverrideUrlLoading(view, request);
        }
    }
}