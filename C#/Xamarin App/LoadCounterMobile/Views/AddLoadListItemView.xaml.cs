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
    public partial class AddLoadListItemView : ContentPage
    {
        public Driver newDriver;
        public AddLoadListItemView(Driver driver)
        {
            InitializeComponent();

            newDriver = driver;

            AddLoadButton.Clicked += (sender, e) => {

                string iDate = LoadTime.Text;
                DateTime LoadDate = Convert.ToDateTime(iDate);

                Load load = new Load();
                load.LoadTimeStamp = LoadDate;
                load.LoadType = LoadType.Text;

                driver.LoadList.Add(load);

                Navigation.PushAsync(new DailyJobDetailsView());
            };

        }
    }
}