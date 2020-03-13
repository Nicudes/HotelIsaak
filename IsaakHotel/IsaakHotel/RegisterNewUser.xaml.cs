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
    public partial class RegisterNewUser : ContentPage
    {
        public RegisterNewUser()
        {
            InitializeComponent();
        }

        private async void btn_CreateUser(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));
        }
    }
}