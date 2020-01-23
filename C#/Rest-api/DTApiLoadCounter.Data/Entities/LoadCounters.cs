using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Entities
{
    public class LoadCounters
    {
        public int LoadCounterId { get; set; }
        public List<DailyJobLoadCounters> DailyJobLoadCounters { get; set; }
    }
}
