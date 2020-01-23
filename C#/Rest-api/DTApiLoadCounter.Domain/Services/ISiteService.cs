using DTApiLoadCounter.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Domain.Services
{
    public interface ISiteService
    {
        IEnumerable<LoadCounterSiteDTO> GetDailyJobSites(int JobId);
    }
}
