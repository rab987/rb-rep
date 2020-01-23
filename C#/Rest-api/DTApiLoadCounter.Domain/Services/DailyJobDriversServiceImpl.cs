using System;
using System.Collections.Generic;
using System.Text;
using DTApiLoadCounter.Data.Entities;
using DTApiLoadCounter.Data.Repositories;
using DTApiLoadCounter.DTO;

namespace DTApiLoadCounter.Domain.Services
{
    public class DailyJobDriversServiceImpl : IDailyJobDriversService
    {
        private IDailyJobDriversRepository DailyJobDriversRepository;
        public DailyJobDriversServiceImpl(IDailyJobDriversRepository dailyJobDriversRepository)
        {
            this.DailyJobDriversRepository = dailyJobDriversRepository;
        }

        public IEnumerable<LoadCounterDriverDTO> GetDailyJobDrivers(int JobId)
        {
            IEnumerable< LoadCounterDriverDTO > result = this.DailyJobDriversRepository.GetDailyJobDrivers(JobId);
            return result;
        }
    }
}
