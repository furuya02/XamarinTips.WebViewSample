using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WebViewSample {
    public class App : Application {
        public App() {
            MainPage = new MyPage();
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }

    public interface IBaseUrl {
        string Get();
    }

    internal class MyPage : ContentPage {
        public MyPage() {

            var html = new HtmlWebViewSource {
                Html =
                    "<html><head><link rel='stylesheet' href='css/my.css'></head><body><h1>TEST</h1><img src='Images/icon.png'>サンプルページ</body></html>",
                BaseUrl = DependencyService.Get<IBaseUrl>().Get(),
            };

            var webView = new WebView {
                Source = html
            };

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = webView;
        }
    }
}
