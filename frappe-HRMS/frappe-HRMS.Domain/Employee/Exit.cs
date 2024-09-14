using frappe_HRMS.Domain.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Domain.Employee
{
    public class Exit : BaseEntity
    {
        public DateTime? ResignationLetterDate { get; set; }
        public DateTime? ExitInterviewHeldOn { get; set; }
        public bool? LeaveEncashed { get; set; }
        public DateTime? RelievingDate { get; set; }
        public string? NewWorkPlace { get; set; }
        public string? ReasonforLeaving { get; set; }
        public string? Feedback { get; set; }
    }
}
