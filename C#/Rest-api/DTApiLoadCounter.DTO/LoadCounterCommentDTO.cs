using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.DTO
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
        public string LastUpdatedBy { get { return CreatedBy + '/' + UpdatedBy; } }
        public string LastUpdatedStamp { get { return CreatedStamp + '/' + UpdatedStamp; } }
    }
}
