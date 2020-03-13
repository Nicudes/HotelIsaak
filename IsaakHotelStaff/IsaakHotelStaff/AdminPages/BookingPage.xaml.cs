using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IsaakHotelStaff.AdminPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingPage : ContentPage
    {
        public BookingPage()
        {
            InitializeComponent();
        }

        private void UpcomingButton_Clicked(object sender, EventArgs e)
        {
            upcomingStackLayout.IsVisible = true;
            activeStackLayout.IsVisible = false;
            historyStackLayout.IsVisible = false;
            
        }

        private void ActiveButton_Clicked(object sender, EventArgs e)
        {
            upcomingStackLayout.IsVisible = false;
            activeStackLayout.IsVisible = true;
            historyStackLayout.IsVisible = false;

        }

        private void HistoryButton_Clicked(object sender, EventArgs e)
        {
            upcomingStackLayout.IsVisible = false;
            activeStackLayout.IsVisible = false;
            historyStackLayout.IsVisible = true;

        }
    }
}