using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace OnlineResturent.Views.AppCore.Core
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : Xamarin.Forms.TabbedPage
    {
        public HomePage ()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            this.CurrentPageChanged += CurrentPageHasChanged;
        }

        protected void CurrentPageHasChanged(object sender, EventArgs e)
        {
            this.Title = CurrentPage.Title;
        }
    }
}