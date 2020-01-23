using System;
using System.Collections.Generic;
using System.Text;

namespace LoadCounterMobile.Models
{
    public class LoadCounter
    {
        public string mSource { get; set; }
        public string mDeliveredTo { get; set; }
        public string mContractor { get; set; }
        public DateTime mLoadCountDate { get; set; }
        public string mChecker { get; set; }
        public int mJobNumber { get; set; }

        public string mFirstName { get; set; }
        public string mLastName { get; set; }
        public float mHours { get; set; }
        public float mRate { get; set; }
        public float mTotal { get; set; }

        public String mFullName
        {
            get { return mFirstName + " " + mLastName; }
        }
    }
}
