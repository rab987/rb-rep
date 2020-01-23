using LoadCounterMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoadCounterMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadCounterLoginView : ContentPage
    {
        public static string Username = "LoadCounter";
        public static string Password = "password";
        public LoadCounterLoginView()
        {
            InitializeComponent();
        }
        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
        //    await Navigation.PushAsync(new SignUpPage());
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new DailyJobDetailsView(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Username && user.Password == Password;
        }
    }
}