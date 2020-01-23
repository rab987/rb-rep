using DTApiLoadCounter.Data.Entities;
using DTApiLoadCounter.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Repositories
{
    public interface IDailyJobRepository
    {
        IEnumerable<LoadCounterDailyJobDTO> GetDailyJobs(int JobId);
    }
}
