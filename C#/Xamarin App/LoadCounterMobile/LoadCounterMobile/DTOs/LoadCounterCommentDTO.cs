using System;
using System.Collections.Generic;
using System.Text;

namespace LoadCounterMobile.DTOs
{
    public class LoadCounterCommentDTO
    {
        public long CommentId { get; set; }
        public long ReferenceId { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedStamp { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedStamp { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedStamp { get; set; }
    }
}
