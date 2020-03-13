using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IsaakHotel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomerPage : ContentPage
    {
        public CustomerPage()
        {
            InitializeComponent();
        }

        private async void btn_Home(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));
        }

        private async void btn_NewBooking(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new BookPage()));
        }

        private async void btn_UpdateInfo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new CustomerInfo()));
        }

        private async void btn_UserBookings(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new CustomerBookings()));
        }
    }
}