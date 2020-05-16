# fb-login-xamarin
1.Create a xamrin app in visual studio
2.place the contents of the facebooklogin folder into your portable folder
3. Copy the Iclearcookies file to the android folder
4.I have only tested this in android 
5.For ios you will have to create another Iclearcookies file with the contents
```C#
using WebViewCookiesDemo.iOS;  
using Xamarin.Forms;  
using Foundation;  
using WebViewCookiesDemo.DependencyServices;  
[assembly: Dependency(typeof(ClearCookies))]  
namespace WebViewCookiesDemo.iOS {  
    public class ClearCookies: IClearCookies {  
        public void ClearAllCookies() {  
            NSHttpCookieStorage CookieStorage = NSHttpCookieStorage.SharedStorage;  
            foreach(var cookie in CookieStorage.Cookies)  
            CookieStorage.DeleteCookie(cookie);  
        }  
    }  
} 
```
Thanks for reading
