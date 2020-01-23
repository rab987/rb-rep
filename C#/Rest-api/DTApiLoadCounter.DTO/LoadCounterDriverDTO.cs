using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.DTO
{
    public class LoadCounterDriverDTO
    {
        public Int64 DailyJobDriverId { get; set; }
        public Int64 DriverId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string MobileNumber { get; set; }
        public string UnitTypeId { get; set; }
        public int UnitNumber { get; set; }
        public string UnitReference { get; set; }
        public DateTime StartTime { get; set; }
        public string PayCode { get; set; }
        public string DivisionId { get; set; }
        public string DivisionName { get; set; }
        
        public string Name
        {
            get{ return FirstName + ' ' + LastName; }
        }
    }
}
