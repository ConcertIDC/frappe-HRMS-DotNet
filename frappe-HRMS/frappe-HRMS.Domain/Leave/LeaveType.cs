using frappe_HRMS.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace frappe_HRMS.Domain.Leave
{
    public class LeaveType : BaseEntity
    {
        public string? Name { get; set; }
        public decimal? MaximumLeaveAllocationAllowed {  get; set; }
        public int? ApplicableAfter {  get; set; }
        public int? MaximumonsecutiveLeavesAllowed { get; set; }
        public bool? IsCarryForward { get; set; }
        public bool? IsLeaveWithoutPay { get; set; }
        public bool? IsPartiallyPaidLeave { get; set; }
        public bool? IsOptionalLeave { get; set; }
        public bool? AllowNegativeBalance { get; set; }   
        public bool? AllowOverAllocation { get; set; }
        public bool? Includeholidayswithinleavesasleaves { get; set; }
        public bool? IsCompensatory { get; set; }
        public bool? AllowEncashment { get; set; }
        public string? MaximumEncashableLeaves {  get; set; }
        public string? NonEncashableLeaves { get; set; }
        public bool? IsEarnedLeave { get; set; }
        public decimal? MaximumCarryForwardedLeaves { get; set; }
        public int? ExpireCarryForwardedLeaves { get; set; }
    }
}
