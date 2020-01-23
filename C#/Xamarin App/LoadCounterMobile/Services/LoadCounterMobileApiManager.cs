using LoadCounterMobile.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoadCounterMobile.Services
{
    public class LoadCounterMobileApiManager
    {
        IGetDailyJobService getDailyJobService;

        public LoadCounterMobileApiManager(IGetDailyJobService jobService)
        {
            getDailyJobService = jobService;
        }

        public Task<LoadCounterDailyJobDTO> GetDailyJobs()
        {
            return getDailyJobService.GetDailyJobs();
        }
        
        public Task<LoadCounterUnitTypeDTO> GetDailyUnitType()
        {
            return getDailyJobService.GetDailyUnitType();
        }
        public Task<IEnumerable<LoadCounterDriverDTO>> GetDailyDrivers()
        {
            return getDailyJobService.GetDailyDrivers();
        }
    }
}
