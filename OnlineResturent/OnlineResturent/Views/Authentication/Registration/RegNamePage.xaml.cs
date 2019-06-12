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
	public partial class RegNamePage : ContentPage
	{
		public RegNamePage ()
		{
			InitializeComponent ();
		}
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegEmailPage());
        }
    }
}