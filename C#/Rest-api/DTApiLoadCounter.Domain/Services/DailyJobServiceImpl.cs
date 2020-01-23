using System;
using System.Collections.Generic;
using System.Text;
using DTApiLoadCounter.Data.Repositories;
using DTApiLoadCounter.DTO;

namespace DTApiLoadCounter.Domain.Services
{
    public class DailyJobServiceImpl : IDailyJobService
    {
        private IDailyJobRepository DailyJobRepository;
        private IDailyJobDriversRepository DailyJobDriversRepository;
        private ICommentsRepository CommentsRepository;
        private ISiteRepository SiteRepository;
        private IUnitTypeRepository UnitTypeRepository;
        public DailyJobServiceImpl(IDailyJobRepository dailyJobRepository, IDailyJobDriversRepository dailyJobDriversRepository, ICommentsRepository commentsRepository,
         ISiteRepository siteRepository, IUnitTypeRepository unitTypeRepository)
        {
            this.DailyJobRepository = dailyJobRepository;
            this.DailyJobDriversRepository = dailyJobDriversRepository;
            this.CommentsRepository = commentsRepository;
            this.SiteRepository = siteRepository;
            this.UnitTypeRepository = unitTypeRepository;
        }

        public LoadCounterDailyJobDTO GetDailyJobs(int JobId)
        {
            IEnumerable<LoadCounterDailyJobDTO> results = this.DailyJobRepository.GetDailyJobs(JobId);
            LoadCounterDailyJobDTO result = new LoadCounterDailyJobDTO();
            foreach(var x in results)
            {
                result = x;
            }
            result.Drivers = this.DailyJobDriversRepository.GetDailyJobDrivers(JobId);
            result.Comments = this.CommentsRepository.GetDailyComments(JobId);
            result.Sites = this.SiteRepository.GetDailySites(JobId);
            result.Units = this.UnitTypeRepository.GetDailyUnitTypes(JobId);

            return result;
        }
    }
}
