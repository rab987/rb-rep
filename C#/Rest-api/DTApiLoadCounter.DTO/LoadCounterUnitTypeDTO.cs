using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.DTO
{
    public class LoadCounterUnitTypeDTO
    {
        public string UnitTypeId { get; set; }
        public string UnitType { get; set; }
        public int Requested { get; set; }
        public int Dispatched { get; set; }
        public DateTime StartTime { get; set; }
        public bool Staggered { get; set; }
        public int Interval { get; set; }
    }
}
