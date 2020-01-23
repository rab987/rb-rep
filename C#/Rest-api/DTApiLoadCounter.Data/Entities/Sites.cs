using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Entities
{
    public class Sites
    {
        public int SiteId { get; set; }
        public List<DailyJobSites> DailyJobSites { get; set; }
    }
}
