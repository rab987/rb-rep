using LoadCounterMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LoadCounterMobile.UIData
{
    public class LoadCounterAppData
    {
        public ObservableCollection<LoadCounter> mLoadCounter { get; set; }
        public ObservableCollection<DailyJob> mDailyJob { get; set; }
        public ObservableCollection<Driver> mDriver { get; set; }

        static ObservableCollection<DailyJob> mDailyJobDataSet = new ObservableCollection<DailyJob> {
        new DailyJob{mJobNumber = 38156, mReceived = "x", mJobDate = DateTime.Now, mApproved = "x", mDeliveryAddress = "29201 Henry Mayo Dr, Chiquita Canyon", mLoadingAddress = "2900 Wilshire Blvd",
        mPreliminaryNotice = "", mJobCustomer = "Calex", mProjectManager = "SW"},
        };

        static ObservableCollection<LoadCounter> mLoadCounterDataSet = new ObservableCollection<LoadCounter> {
        new LoadCounter{mSource = "2900 Wilshire Blvd", mLoadCountDate = DateTime.Now, mDeliveredTo = "Chiquita Canyon", mChecker = "Richardo", mContractor = "Colex", mJobNumber = 38156},
        };

        static ObservableCollection<Driver> mDriverDataSet = new ObservableCollection < Driver > {
        new Driver{mDriverNumber = 1, mTruckNumber = 12, mFirstName = "Joe", mLastName = "Test", mHours = 200, mLoadIn = 1, mExpectedLoadIn = 10, mLoadOut = 1, mExpectedLoadOut = 10, mManifestNumber = 038296, mTicketNumber = 799019, mPaycode = 345,
            LoadList = new List<Load> { new Load { LoadType = "1", LoadTimeStamp = DateTime.Now }, new Load { LoadType = "4", LoadTimeStamp = DateTime.Now } } },
        new Driver{mDriverNumber = 2, mTruckNumber = 20, mFirstName = "John", mLastName = "Doe", mHours = 400, mLoadIn = 2, mExpectedLoadIn = 15, mLoadOut = 2, mExpectedLoadOut = 15, mManifestNumber = 038294, mTicketNumber = 456019, mPaycode = 567,
        LoadList = new List<Load> { new Load { LoadType = "3", LoadTimeStamp = DateTime.Now }, new Load { LoadType = "4", LoadTimeStamp = DateTime.Now } }},
        new Driver{mDriverNumber = 3, mTruckNumber = 50, mFirstName = "Tester", mLastName = "Guy", mHours = 300, mLoadIn = 3, mExpectedLoadIn = 20, mLoadOut = 3, mExpectedLoadOut = 20, mManifestNumber = 038293, mTicketNumber = 123019, mPaycode = 678,
        LoadList = new List<Load> { new Load { LoadType = "1", LoadTimeStamp = DateTime.Now }, new Load { LoadType = "2", LoadTimeStamp = DateTime.Now } }},
        new Driver{mDriverNumber = 4, mTruckNumber = 40, mFirstName = "Guy", mLastName = "Tester", mHours = 500, mLoadIn = 4, mExpectedLoadIn = 12, mLoadOut = 4, mExpectedLoadOut = 12, mManifestNumber = 038292, mTicketNumber = 789019, mPaycode = 789,
        LoadList = new List<Load> { new Load { LoadType = "3", LoadTimeStamp = DateTime.Now }, new Load { LoadType = "2", LoadTimeStamp = DateTime.Now } }},
        new Driver{mDriverNumber = 5, mTruckNumber = 55, mFirstName = "Ron", mLastName = "Test", mHours = 400, mLoadIn = 5, mExpectedLoadIn = 10, mLoadOut = 5, mExpectedLoadOut = 10, mManifestNumber = 038255, mTicketNumber = 799077, mPaycode = 432,
        LoadList = new List<Load> { new Load { LoadType = "1", LoadTimeStamp = DateTime.Now }, new Load { LoadType = "4", LoadTimeStamp = DateTime.Now } }},
        new Driver{mDriverNumber = 6, mTruckNumber = 25, mFirstName = "Paul", mLastName = "Doe", mHours = 200, mLoadIn = 7, mExpectedLoadIn = 15, mLoadOut = 5, mExpectedLoadOut = 15, mManifestNumber = 038244, mTicketNumber = 456044, mPaycode = 454,
        LoadList = new List<Load> { new Load { LoadType = "3", LoadTimeStamp = DateTime.Now }, new Load { LoadType = "2", LoadTimeStamp = DateTime.Now } }},
        new Driver{mDriverNumber = 7, mTruckNumber = 70, mFirstName = "Joe", mLastName = "Guy", mHours = 300, mLoadIn = 4, mExpectedLoadIn = 20, mLoadOut = 7, mExpectedLoadOut = 20, mManifestNumber = 038277, mTicketNumber = 123055, mPaycode = 765,
        LoadList = new List<Load> { new Load { LoadType = "1", LoadTimeStamp = DateTime.Now }, new Load { LoadType = "2", LoadTimeStamp = DateTime.Now } }},
        new Driver{mDriverNumber = 8, mTruckNumber = 100, mFirstName = "TestGuy", mLastName = "Tester", mHours = 700, mLoadIn = 10, mExpectedLoadIn = 12, mLoadOut = 4, mExpectedLoadOut = 12, mManifestNumber = 038774, mTicketNumber = 789777, mPaycode = 7543,
        LoadList = new List<Load> { new Load { LoadType = "3", LoadTimeStamp = DateTime.Now }, new Load { LoadType = "4", LoadTimeStamp = DateTime.Now } }},
        };

        public LoadCounterAppData()
        {
            mLoadCounter = mLoadCounterDataSet;
            mDriver = mDriverDataSet;
            mDailyJob = mDailyJobDataSet;
        }
    }
}
