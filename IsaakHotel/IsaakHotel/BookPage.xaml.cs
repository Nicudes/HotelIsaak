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

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            Recalculate();
        }

        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            Recalculate();
        }

        void Recalculate()
        {
            TimeSpan timeSpan = CheckOutDatePicker.Date - CheckInDatePicker.Date;

            resultLabel.Text = String.Format("Book for {0} night{1}",
                                                timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        }

        private void ShowAvailableRoomsButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}