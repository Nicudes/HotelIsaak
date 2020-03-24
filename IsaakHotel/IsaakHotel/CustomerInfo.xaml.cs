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
    public partial class CustomerInfo : ContentPage
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private async void btn_SaveInfo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new CustomerPage()));
        }

        private void btn_EditInfo(object sender, EventArgs e)
        {
            Name.IsReadOnly = false;
            Name.Text = "";
            Name.Placeholder = "Enter name";

            Phone.IsReadOnly = false;
            Phone.Text = "";
            Phone.Placeholder = "Enter phone number";

            Mail.IsReadOnly = false;
            Mail.Text = "";
            Mail.Placeholder = "Enter mail here";

            Nationality.IsReadOnly = false;
            Nationality.Text = "";
            Nationality.Placeholder = "Enter nationality here";
        }
    }
}