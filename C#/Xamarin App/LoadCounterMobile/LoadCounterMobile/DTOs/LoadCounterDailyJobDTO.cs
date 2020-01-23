using System;
using System.Collections.Generic;
using System.Text;

namespace LoadCounterMobile.DTOs
{
    public class LoadCounterDailyJobDTO
    {
        public string DailyJobId { get; set; }                            // DailyJobs.Id
        public string LoadCounterId { get; set; }                         // LoadCounters.Id
        public string LoadCounterFirstName { get; set; }
        public string LoadCounterLastName { get; set; }
        public string LoadCounterName { get { return LoadCounterFirstName + ' ' + LoadCounterLastName; } }  // LoadCounters.FirstName + ' ' + LoadCounters.LastName
        public string LoadCounterUsername { get; set; }                 // LoadCounter.Username ***** Needs to be added to schema!!!
        public string JobName { get; set; }                             // Jobs.Description
        public string PMFirstName { get; set; }
        public string PMLastName { get; set; }
        public string ProjectManagerName { get; set; }                  // ProjectManger2.FirstName +  ' ' + ProjectManager2.LastName
        public string DivisionId { get; set; }                         // DailyJob.DivisionId
        public string DivisionName { get; set; }                        // Divisions.DivisionName
        public DateTime WorkDate { get; set; }                          // DailyJobs.WorkDate
        public IEnumerable<LoadCounterSiteDTO> Sites { get; set; }
        public IEnumerable<LoadCounterUnitTypeDTO> Units { get; set; }
        public IEnumerable<LoadCounterDriverDTO> Drivers { get; set; }
        public IEnumerable<LoadCounterCommentDTO> Comments { get; set; }
    }
}
