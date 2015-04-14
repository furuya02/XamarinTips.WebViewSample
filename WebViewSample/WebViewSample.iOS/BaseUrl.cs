using Foundation;
using WebViewSample.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace WebViewSample.iOS{
    public class BaseUrl : IBaseUrl{
        public string Get(){
            return NSBundle.MainBundle.BundlePath + "/Content";
        }
    }
}