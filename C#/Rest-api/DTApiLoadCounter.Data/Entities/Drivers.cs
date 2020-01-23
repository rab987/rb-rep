using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Entities
{
    public class Drivers
    {
        public int DriverId { get; set; }
        public List<DailyJobDrivers> DailyJobLoadDriver { get; set; }
    }
}
