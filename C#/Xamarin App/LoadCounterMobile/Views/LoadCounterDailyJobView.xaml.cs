using LoadCounterMobile.Models;
using LoadCounterMobile.UIData;
using LoadCounterMobile.Controllers;
using LoadCounterMobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace LoadCounterMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadCounterDailyJobView : ContentPage
    {
        LoadCounterAppData appData;
        static int LoadNum;
        public LoadCounterDailyJobView()
        {
            InitializeComponent();

            appData = new LoadCounterAppData();
 
            List<LoadCounter> loadCounterList = appData.mLoadCounter.ToList();
            List<Driver> driverList = appData.mDriver.ToList();

            dailyDriverList.ItemsSource = driverList;
            dailyDriverList.SelectionMode = SelectionMode.Single;
            dailyDriverList.SelectionChanged += LaunchDriverLoadDetails;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            LoadCounterMobileApiManager apiManager;
            IGetDailyJobService service = new GetDailyJobService();

            apiManager = new LoadCounterMobileApiManager(service);
            var jobData = await apiManager.GetDailyJobs();
            //var driverData = await apiManager.GetDailyDrivers();      This is the real mapping
            //var UnitTypeData = await apiManager.GetDailyUnitType();   This is Commented out until all mock data is removed

            //UnitTypeInfo.Text = UnitTypeData.UnitTypeDisplay;
            //dailyDriverList.ItemsSource = driverData;

            LCDate.Text = jobData.WorkDate.ToString();
            LCJobDescription.Text = jobData.JobName;
            LCJobNum.Text = jobData.DailyJobId;

            PM.Text = jobData.ProjectManagerName;
            
        }

        async void LaunchDriverLoadDetails(object sender, SelectionChangedEventArgs e)
        {
            var previous = (e.PreviousSelection.FirstOrDefault() as Driver)?.LoadList;
            var current = (e.CurrentSelection.FirstOrDefault() as Driver);

            await Navigation.PushAsync(new DriverLoadDetailsView(current)); 
        }

        public void IncrementLoad(object sender, SelectionChangedEventArgs e)
        {
            var current = (e.CurrentSelection.FirstOrDefault() as Driver);

            int loadNum = current.mLoadIn + 1;

            current.mLoadIn = loadNum;
        }
    }
}