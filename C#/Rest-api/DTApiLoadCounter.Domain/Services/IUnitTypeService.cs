using DTApiLoadCounter.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Domain.Services
{
    public interface IUnitTypeService
    {
        IEnumerable<LoadCounterUnitTypeDTO> GetDailyJobUnitTypes(int JobId);
    }
}
