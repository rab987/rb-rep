using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Entities
{
    public class Jobs
    {
        public int JobsId { get; set; }
        public int DailyJobId { get; set; }
        public int UnitTypeId { get; set; }
        public int ProjectManagerId { get; set; }
    }
}
