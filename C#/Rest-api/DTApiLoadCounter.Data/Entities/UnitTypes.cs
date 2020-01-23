using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Entities
{
    public class UnitTypes
    {
        public int UnitTypesID { get; set; }
        public List<DailyJobUnitTypes> DailyJobUnitTypes { get; set; }
    }
}
