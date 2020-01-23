using System;
using System.Collections.Generic;
using System.Text;

namespace LoadCounterMobile.Models
{
    public class Load
    {
        public string LoadType { get; set; }
        public DateTime LoadTimeStamp { get; set; }
        public string LoadInfo { get { return LoadType + " " + LoadTimeStamp.ToString(); } }
    }
}
