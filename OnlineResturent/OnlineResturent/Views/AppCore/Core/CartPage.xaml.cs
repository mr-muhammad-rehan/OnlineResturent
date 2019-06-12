using OnlineResturent.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineResturent.Views.AppCore.Core
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CartPage : ContentPage
	{
        public CartPage()
        {
            InitializeComponent();

            var vm = new ItemVM();
            myList.ItemsSource = vm.AddOns;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var vm = new ItemVM();
            myList.ItemsSource = vm.AddOns;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new EmptyCartPage());
        }
    }
}