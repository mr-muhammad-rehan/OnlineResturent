using OnlineResturent.Views.AppCore.Home;
using OnlineResturent.Views.AppCore.Profile;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineResturent.Views.AppCore.Core
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrderHomePage : ContentPage
	{
        public ObservableCollection<YourFovarate> YourFaverates { get; set; }
        public OrderHomePage()
        {
            InitializeComponent();

            YourFaverates = new ObservableCollection<YourFovarate>()
            {
                new YourFovarate{Name="Operation Falafel Quinoa Tabbouleh", Description="", Price="19", ImageUrl="https://i.ibb.co/sPbSPf6/operation-falafel-cl-Ns-E00.jpg"},
                new YourFovarate{Name="Operation Falafel Chicken Salad", Description="", Price="22", ImageUrl="https://i.ibb.co/3YVvy8V/operation-falafel-fo-TSyfb.jpg"},
                new YourFovarate{Name="Operation Falafel Fattoush", Description="", Price="23", ImageUrl="https://i.ibb.co/hYV7Xms/operation-falafel-hu-8-KVTS.jpg"},

            };

            BindingContext = this;
        }


        public class Item
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
            public string ImageUrl { get; set; }

        }

        public class YourFovarate : Item
        {

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemDetailsPage());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfileHomePage());
        }
    }
}