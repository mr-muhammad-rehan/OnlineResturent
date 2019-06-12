using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineResturent.Views.Authentication.Registration
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterationSucessPage : ContentPage
	{
		public RegisterationSucessPage ()
		{
			InitializeComponent ();
		}

        private  void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new SignInPage();
        }
    }
}