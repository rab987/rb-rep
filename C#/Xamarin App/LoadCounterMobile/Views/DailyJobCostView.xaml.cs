using LoadCounterMobile.Models;
using LoadCounterMobile.UIData;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace LoadCounterMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DailyJobCostView : ContentPage
    {
        public ObservableCollection<Driver> Drivers { get; set; }

        public DailyJobCostView()
        {
            InitializeComponent();

            LoadCounterAppData appData = new LoadCounterAppData();

            mDJJobNum.Text = appData.mDailyJob[0].mJobNumber.ToString();
            mDJReceived.Text = appData.mDailyJob[0].mReceived;
            mDJDate.Text = appData.mDailyJob[0].mJobDate.ToString();
            mDJPM.Text = appData.mDailyJob[0].mProjectManager;
            mDJApproved.Text = appData.mDailyJob[0].mApproved;
            mDJLoadingAddress.Text = appData.mDailyJob[0].mLoadingAddress;
            mDJCustomers.Text = appData.mDailyJob[0].mJobCustomer;
            mDJDeliveryAddress.Text = appData.mDailyJob[0].mDeliveryAddress;
            mDJPN.Text = appData.mDailyJob[0].mPreliminaryNotice;

            Drivers = appData.mDriver;

            MyListView.ItemsSource = Drivers;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
           
        }

        async void ListViewVisibility(object sender, EventArgs e)
        {
       
            
        }
    }
}
