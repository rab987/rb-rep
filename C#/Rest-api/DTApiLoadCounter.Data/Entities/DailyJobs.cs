using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Entities
{
    public class DailyJobs
    {
        public Int64 Id { get; set; }
        public Int64 CopyFromDailyJobId { get; set; }
        public string DepartmentId { get; set; }
        public string DivisionId { get; set; }
        public string JobId { get; set; }
        public Int64 LoadSiteId { get; set; }
        public string PmId { get; set; }
        public DateTime? WorkDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedStamp { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedStamp { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedStamp { get; set; }
        public int TestEntry { get; set; }
    }
}
