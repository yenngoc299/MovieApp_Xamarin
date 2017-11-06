using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.View;
using MovieApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace MovieApp.View
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeigh;
            Entry_Username.Completed += (sender, e) => Entry_Password.Focus();
            Entry_Password.Completed += (sender, e) => SignInProcedureAsync(sender, e);
        }

        async Task SignInProcedureAsync(object seder, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            { 
                DisplayAlert("Login", "Login Success", "Okie");
                var result = await App.RestService.Login(user);
                App.UserDatabase.SaveUser(user);
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct", "Empty user name or password", "Okie");
            }
        }
    }
}
