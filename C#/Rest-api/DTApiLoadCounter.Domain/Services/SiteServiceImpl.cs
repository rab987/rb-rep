using DTApiLoadCounter.Data.Repositories;
using DTApiLoadCounter.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Domain.Services
{
    public class SiteServiceImpl : ISiteService
    {
        private ISiteRepository SiteRepository;

        public SiteServiceImpl(ISiteRepository siteRepository)
        {
            this.SiteRepository = siteRepository;
        }

        public IEnumerable<LoadCounterSiteDTO> GetDailyJobSites(int JobId)
        {
            IEnumerable<LoadCounterSiteDTO> result = this.SiteRepository.GetDailySites(JobId);
            return result;
        }
    }
}
