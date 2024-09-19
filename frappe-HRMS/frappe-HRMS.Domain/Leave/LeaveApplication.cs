using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Employee;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Leave
{
    public class LeaveApplication : BaseEntity
    {
        public string Series => $"HR-LAP-{DateTime.Now.Year}-000{Id.ToString()}";
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee.Employee? Employee { get; set; }
        public int? LeaveTypeId { get; set; }
        [ForeignKey(nameof(LeaveTypeId))]
        public virtual LeaveType? LeaveType { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company.Company? Company { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? Reason {  get; set; }
        public bool? HalfDay {  get; set; }
        public string? LeaveApprover { get; set; }
        public int? UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }
        public DateTime? PostingDate { get; set; }
        public string? Status { get; set; }
        public bool? FollowviaEmail { get; set; }
    }
}
