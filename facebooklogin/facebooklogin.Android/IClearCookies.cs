using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using facebooklogin.Droid;
using Xamarin.Forms;
using facebooklogin;

[assembly: Dependency(typeof(IClearCookies))]
namespace facebooklogin.Droid
{
    public class IClearCookies: clearcookies
    {
        public void clear()
        {
            var cookieManager = CookieManager.Instance;
            cookieManager.RemoveAllCookie();
        }
    }
}