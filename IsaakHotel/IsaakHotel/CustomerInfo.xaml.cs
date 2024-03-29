﻿using System;
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
    }
}