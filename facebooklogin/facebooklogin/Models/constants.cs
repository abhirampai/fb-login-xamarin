using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace facebooklogin.Models
{
    class constants
    {


        public static bool isDev = true;
        public static Color BackgroundColor = Color.FromRgb(58, 153, 215);
        public static Color MainTextColor = Color.White;
        public static string RequestUri = "https://graph.facebook.com/v7.0/me/?fields=name,friends,picture,work,website,religion,location,locale,link,cover,age_range,birthday,devices,email,first_name,last_name,gender,hometown,is_verified,languages&access_token={0}";
        
    }
}
