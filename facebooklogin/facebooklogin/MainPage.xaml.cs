using facebooklogin.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace facebooklogin
{
    public partial class MainPage : ContentPage
    {
        private string client_Id = "246725023088558";//replace with your clientId
        public MainPage()
        {

            InitializeComponent();
            var api_request = "https://www.facebook.com/v7.0/dialog/oauth?client_id=" + client_Id + "&display=popup&response_type=token&redirect_uri=https://www.facebook.com/connect/login_success.html&scope=user_birthday,user_friends,email,public_profile";
            var webview = new WebView { Source = api_request, HeightRequest = 1 };
            webview.Navigated += WebViewOnNavigatedAsync;
            Content = webview;

        }

        private async void WebViewOnNavigatedAsync(object sender, WebNavigatedEventArgs e)
        {
            var accessToken = ExtractAccessTokenFromUrl(e.Url);
            string a = accessToken.ToString();
           
            if (accessToken.ToString() != "")
            {
                await Navigation.PushAsync(new NavigationPage(new profile(a)));
            }
        }

        public object ExtractAccessTokenFromUrl(string url)
        {
            if (url.Contains("access_token") && (url.Contains("&expires_in=")))
            {
                var at = url.Replace("https://www.facebook.com/connect/login_success.html#access_token=", "");
                var accessToken = at.Remove(at.IndexOf("&data_access_expiration_time="));
                
                return accessToken;
            }
            return string.Empty;
        }
        
    }
}
