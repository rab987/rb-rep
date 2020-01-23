using System;
using System.Collections.Generic;
using System.Text;

namespace LoadCounterMobile.DTOs
{
    public class LoadCounterSiteDTO
    {
        public long SiteId { get; set; }
        public string SiteType { get; set; }
        public string SiteName { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
    }
}
