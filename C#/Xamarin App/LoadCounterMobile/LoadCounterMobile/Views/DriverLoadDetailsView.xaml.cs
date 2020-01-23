using Android.Views;
using LoadCounterMobile.Listeners;
using LoadCounterMobile.Models;
using LoadCounterMobile.UIData;
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
    public partial class DriverLoadDetailsView : ContentPage
    {
        public int ButtonCount;
        public bool tapHandled;
        public List<Load> LoadList;
        LoadCounterAppData appData;
        public DriverLoadDetailsView(Driver driver)
        {
            InitializeComponent();

            appData = new LoadCounterAppData();

            LoadList = driver.LoadList;
            MyListView.ItemsSource = LoadList;

            JobName.Text = appData.mDailyJob[0].mJobCustomer;
            JobNum.Text = appData.mDailyJob[0].mJobNumber.ToString();

            DriverPaycode.Text = driver.mPaycode.ToString();
            DriverName.Text = driver.mFullName;

            MyListView.ItemTapped += (sender, e) =>
            {
                var selectedLoadDriver = (e.Item as Driver);
                var selectedLoadType = (e.Item as Load)?.LoadType;
                var selectedLoadTime = (e.Item as Load)?.LoadTimeStamp.ToString();
                if (ButtonCount < 1)
                {
                    TimeSpan tt = new TimeSpan(0, 0, 1);
                    System.Func<bool> t1 = new System.Func<bool>(() => TestHandleFunc(selectedLoadDriver, selectedLoadTime, selectedLoadType));
                    Device.StartTimer(tt, t1);
                }
                ButtonCount++;
            };

            AddButton.Clicked += (sender, e) => {

                 Navigation.PushAsync(new AddLoadListItemView(driver));

            };
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            ((ListView)sender).SelectedItem = null;
        }

        public bool TestHandleFunc(Driver driver, string time, string type)
        {
            if (ButtonCount > 1)
            {
                Navigation.PushAsync(new ModifyLoadListItemView(driver, time, type));
            }
            else
            {
            }
            ButtonCount = 0;
            return false;
        }

        public void PencilLaunchEditLoad(object sender, EventArgs e)
        {
            Driver driver = new Driver();

            Navigation.PushAsync(new DriverLoadDetailsView(driver)); 
        }

        public void DeleteLoad(object sender, EventArgs e)
        {

            ImageButton button = (ImageButton)sender;
            StackLayout ListItemLabel = (StackLayout)button.Parent;

            Label load = (Label)ListItemLabel.Children[0];

            load.Text = "";
        }
    }
}