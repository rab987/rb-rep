using LoadCounterMobile.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoadCounterMobile.Services
{
    public interface IGetDailyJobService
    {
        Task<LoadCounterDailyJobDTO> GetDailyJobs();
        Task<LoadCounterUnitTypeDTO> GetDailyUnitType();
        Task<IEnumerable<LoadCounterDriverDTO>> GetDailyDrivers();
    }
}
