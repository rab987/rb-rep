using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTApiLoadCounter.WebApi.Payloads
{
    public class LoadCounterDailyJobPayload
    {
        public string CompanyId { get; set; }
        public int DailyJobId { get; set; }
    }
}
