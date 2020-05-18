using facebooklogin.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace facebooklogin
{
    public partial class App : Application
    {
        static RestApi restService;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
           
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=78560781-5413-4fa6-9039-eba8e8a11ae6;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        public static RestApi RestService
        {
            get
            {
                if (restService == null)
                {
                    restService = new RestApi();
                }
                return restService;
            }
        }
    }
}
