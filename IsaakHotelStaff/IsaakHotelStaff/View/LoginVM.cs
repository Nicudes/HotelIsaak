using IsaakHotelStaff.View.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IsaakHotelStaff.View
{
    public class LoginVM : INotifyPropertyChanged
    {
  
        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged("Email");
                OnPropertyChanged("CanLogin");
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
                OnPropertyChanged("CanLogin");
            }
        }
        
        public bool CanLogin
        {
            get
            {
                return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);
            }

        }

        public ICommand LoginCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginVM()
        {
            LoginCommand = new Command(Login, LoginCanExecute);
        }

        private async void Login(object parameter)
        {
            await Auth.AuthenticateUser(Email, Password);
        }
        private bool LoginCanExecute(object parameter)
        {
            return CanLogin;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
