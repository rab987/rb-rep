using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Entities
{
    public class DailyJobLoadCounters
    {
        public int DailyJobLoadCounterId { get; set; }
        public int DailyJobId { get; set; }
        public int LoadCounterId { get; set; }
    }
}
