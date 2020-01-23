using System;
using System.Collections.Generic;
using System.Text;

namespace LoadCounterMobile.Models
{
    public class DailyJob
    {
        public int mJobNumber { get; set; }
        public string mProjectManager { get; set; }
        public string mApproved { get; set; }
        public string mReceived { get; set; }
        public string mPreliminaryNotice { get; set; }
        public DateTime mJobDate { get; set; }
        public string mLoadingAddress { get; set; }
        public string mJobCustomer { get; set; }
        public string mDeliveryAddress { get; set; }

    }
}
