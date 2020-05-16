using facebooklogin.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
