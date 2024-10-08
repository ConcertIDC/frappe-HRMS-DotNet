using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Claim
{
    public class ExpenseClaim : BaseEntity
    {
        public string Series => $"HR-EXP-{DateTime.Now.Year}-000{Id.ToString()}";
        public string? ExpenseApprover => Employee?.EmployeeAttendanceLeaves?.ExpenseApprover?.FullName ?? null;
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee.Employee? Employee { get; set; }
        public string? ApprovalStatus { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company.Company? Company { get; set; }
    }
}
