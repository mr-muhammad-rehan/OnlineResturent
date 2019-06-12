using OnlineResturent.Views.AppCore.Core;
using OnlineResturent.Views.Authentication.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineResturent.Views.Authentication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignInPage : ContentPage
	{
		public SignInPage ()
		{
			InitializeComponent ();
		}

        private async void TapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new RegNamePage());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new ForgotPasswordPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new HomePage());
        }

        private void Button_Agree_Terms(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("#FF5230");
        }
    }
}