using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShopApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }

        private async void QuickBites_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuickBitesPage());
        }

        private async void ColdDrinks_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColdDrinksPage());
        }

        private async void HotDrinks_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotDrinksPage());
        }

        private async void Espresso_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspressoPage());
        }
    }
}