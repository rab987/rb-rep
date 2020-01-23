using LoadCounterMobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoadCounterMobile
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public App()
        {
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoadCounterLoginView());
            }
            else
            {
                MainPage = new NavigationPage(new DailyJobDetailsView());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
