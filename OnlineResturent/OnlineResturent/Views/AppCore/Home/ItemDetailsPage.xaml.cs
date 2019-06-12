using OnlineResturent.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineResturent.Views.AppCore.Home
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetailsPage : ContentPage
	{
		public ItemDetailsPage ()
		{
			InitializeComponent ();
            BindingContext = new ItemVM();
        }
	}
}