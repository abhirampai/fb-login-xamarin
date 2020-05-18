using facebooklogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace facebooklogin.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class profile : ContentPage
	{
        string AccessToken;
		public profile (string accessToken)
		{
            AccessToken = accessToken;
			InitializeComponent ();
            InitAsync(accessToken);
		}

        private async void InitAsync(string accessToken)
        {
            var profileDetails = await App.RestService.GetDetails(accessToken);
            if (profileDetails != null)
            {
                ProfileDp.Source = profileDetails.Picture.Data.Url;
                ProfileDp.WidthRequest = profileDetails.Picture.Data.Width;
                ProfileDp.HeightRequest = profileDetails.Picture.Data.Height;
                Name.Text = profileDetails.Name;
                DOB.Text = profileDetails.Birthday;
                friends.Text = profileDetails.Friends.Summary.TotalCount.ToString();
            }
        }

        private async void LogoutButton_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<clearcookies>().clear();
            profile1.Opacity=0;
            await DisplayAlert("Logout","Logout Successfull", "Ok");
            await Navigation.PushAsync(new NavigationPage(new MainPage()));
        }
    }
}