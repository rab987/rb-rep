using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Entities
{
    public class DailyJobSites
    {
        public int DailyJobSitesId { get; set; }
        public int DailyJobId { get; set; }
        public int SiteId { get; set; }
    }
}
