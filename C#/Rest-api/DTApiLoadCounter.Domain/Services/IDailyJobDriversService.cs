using DTApiLoadCounter.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Domain.Services
{
    public interface IDailyJobDriversService
    {
        IEnumerable<LoadCounterDriverDTO> GetDailyJobDrivers(int JobId);
    }
}
