using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IsaakHotelStaff.View.Helpers
{
    public interface IAuth
    {
        Task<bool> AuthenticateUser(string email, string password);
        bool IsAuthenticated();
        string GetCurrentUserId();
    }
    class Auth
    {
        private static IAuth auth = DependencyService.Get<IAuth>();

        public static async Task<bool> AuthenticateUser(string email, string password)
        {
            try
            {
              return await auth.AuthenticateUser(email, password);
            }
            catch(Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
                return false;
            }
           
        }

        public static bool IsAuthenticated()
        {
            return auth.IsAuthenticated();
        }

        public static string GetCurrentUserId()
        {
            return auth.GetCurrentUserId();
        }
    }
}
