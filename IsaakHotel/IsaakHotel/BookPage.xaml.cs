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
    public partial class BookPage : ContentPage
    {
        public BookPage()
        {
            InitializeComponent();
        }

        private void btn_AvailibleRooms(object sender, EventArgs e)
        {
            visaMer.Text = ("Nu visas tillgängliga rum");
        }

        private void btn_RoomDetails(object sender, EventArgs e)
        {
            visaMer.Text = ("Nu visas mer info om rummet");
        }

        private async void btn_BookThisRoom(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ConfirmationPage()));
        }
    }
}