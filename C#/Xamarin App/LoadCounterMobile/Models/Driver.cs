using System;
using System.Collections.Generic;
using System.Text;

namespace LoadCounterMobile.Models
{
    public class Driver
    {
        public int mDriverNumber { get; set; }
        public int mTruckNumber { get; set; }
        public int mLoadIn { get; set; }
        public int mExpectedLoadIn { get; set; }
        public int mLoadOut { get; set; }
        public int mExpectedLoadOut { get; set; }
        public int mManifestNumber { get; set; }
        public int mTicketNumber { get; set; }
        public int mPaycode { get; set; }

        public string mFirstName { get; set; }
        public string mLastName { get; set; }
        public float mRate { get; set; }
        public float mTotal { get; set; }
        public float mHours { get; set; }

        public List<Load> LoadList { get; set; }

        public String mFullName
        {
            get { return mFirstName + " " + mLastName; }
        }

        public String mDailyLoadIn
        {
            get { return mLoadIn + "/" + mExpectedLoadIn; }
        }

        public String mDailyLoadOut
        {
            get { return mLoadOut + "/" + mExpectedLoadOut; }
        }
        public String mDailyLoadCount
        {
            get { return AddLoads(mLoadIn, mLoadOut); }
        }
        public String AddLoads(int LoadIn, int LoadOut)
        {
            int total = LoadIn + LoadOut;
            return total.ToString();
        }
    }
}
