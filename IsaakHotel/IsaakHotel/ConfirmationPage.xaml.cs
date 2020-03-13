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
    public partial class ConfirmationPage : ContentPage
    {
        public ConfirmationPage()
        {
            InitializeComponent();
        }

        private void btn_Login(object sender, EventArgs e)
        {
            LoginButton.Text = "yes";
        }

        private async void btn_RegisterNewUser(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new RegisterNewUser()));
        }

        private void btn_Pay(object sender, EventArgs e)
        {
            Payment.Text = "Paid!";
        }

        private async void btn_BackToStart(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));
        }
    }
}