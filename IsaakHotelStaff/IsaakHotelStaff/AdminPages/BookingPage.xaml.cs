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
            upcomingButton.IsVisible = true;
            
        }

        private void ActiveButton_Clicked(object sender, EventArgs e)
        {

        }

        private void HistoryButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}