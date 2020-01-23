using DTApiLoadCounter.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Repositories
{
    public interface ISiteRepository
    {
        IEnumerable<LoadCounterSiteDTO> GetDailySites(int JobId);
    }
}
