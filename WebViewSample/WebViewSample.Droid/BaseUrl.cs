using WebViewSample.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))] 
namespace WebViewSample.Droid{
    public class BaseUrl : IBaseUrl{ 
        public string Get() {
            return "file:///android_asset/Content/"; 
        }
    }
}

