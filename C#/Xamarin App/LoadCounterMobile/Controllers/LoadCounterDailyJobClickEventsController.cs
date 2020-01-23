using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

using LoadCounterMobile.Models;
using LoadCounterMobile.Views;

namespace LoadCounterMobile.Controllers
{
    public class LoadCounterDailyJobClickEventsController : ContentPage
    {
        public void LoadInButtonClicked(object sender, EventArgs args)
        {
           
        }

        public void LoadOutButtonClicked(object sender, EventArgs args)
        {

        }
        public async void LaunchDailyJobCost(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new DailyJobCostView(), this);
            await Navigation.PopAsync();
        }
    }
}
