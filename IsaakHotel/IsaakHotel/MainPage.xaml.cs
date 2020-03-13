using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IsaakHotel
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Testkommentar by André

        }

        private async void btn_NewBooking(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new BookPage()));

        }

        private async void btn_SignIn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new CustomerPage()));
        }

        private async void btn_RegisterNewUser(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new RegisterNewUser()));
        }

        private async void btn_Reviews(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Reviews()));
        }

        private async void btn_AboutUs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new BookPage()));
        }
    }
}
