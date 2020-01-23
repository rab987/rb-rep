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
    public partial class ModifyLoadListItemView : ContentPage
    {
        public Load selectedLoad;
        public ModifyLoadListItemView(Driver driver, string time, string type)
        {
            InitializeComponent();

            LoadType.Text = type;
            LoadTime.Text = time;

        }
    }
}