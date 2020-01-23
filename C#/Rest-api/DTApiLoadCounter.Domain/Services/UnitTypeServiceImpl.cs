using System;
using System.Collections.Generic;
using System.Text;
using DTApiLoadCounter.Data.Repositories;
using DTApiLoadCounter.DTO;

namespace DTApiLoadCounter.Domain.Services
{
    public class UnitTypeServiceImpl : IUnitTypeService
    {
        private IUnitTypeRepository UnitTypeRepository;
        public UnitTypeServiceImpl(IUnitTypeRepository unitTypeRepository)
        {
            this.UnitTypeRepository = unitTypeRepository;
        }
        public IEnumerable<LoadCounterUnitTypeDTO> GetDailyJobUnitTypes(int JobId)
        {
            IEnumerable<LoadCounterUnitTypeDTO> result = this.UnitTypeRepository.GetDailyUnitTypes(JobId);
            return result;
        }
    }
}
