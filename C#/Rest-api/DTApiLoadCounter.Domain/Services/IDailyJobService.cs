using DTApiLoadCounter.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Domain.Services
{
    public interface IDailyJobService
    {
       LoadCounterDailyJobDTO GetDailyJobs(int JobId);
    }
}
