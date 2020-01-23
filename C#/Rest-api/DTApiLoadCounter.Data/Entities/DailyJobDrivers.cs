using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Entities
{
    public class DailyJobDrivers
    {
        public Int64 Id { get; set; }
        public Int64 DailyJobID { get; set; }
        public Int64 DriverID { get; set; }
        public int UnitNumber { get; set; }
        public string UnitTypeID { get; set; }
        public int Status { get; set; }
        public int DispatchMethod { get; set; }
        public DateTime? WorkDate { get; set; }
        public string DispatchedSignature { get; set; }
        public DateTime? DispatchedStamp { get; set; }
        public string FreightBillReceived { get; set; }
        public string FreightBillReceivedSignature { get; set; }
        public DateTime? FreightBillReceivedStamp { get; set; }
        public string Contacted { get; set; }
        public string ContactedSignature { get; set; }
        public DateTime? ContactedStamp { get; set; }
        public string JobCancelledSignature { get; set; }
        public DateTime? JobCancelledStamp { get; set; }
        public Int64 CopyFromDailyJobID { get; set; }
        public string LastAction { get; set; }
        public string NoShowBy { get; set; }
        public DateTime? NoShowStamp { get; set; }
        public string Signature { get; set; }
        public DateTime? SigStamp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedStamp { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedStamp { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedStamp { get; set; }
        public int TestEntry { get; set; }
    }
}
