using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Employee;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Claim
{
    public class Expenses : BaseEntity
    {
        public DateTime? ExpenseDate { get; set; }
        public string? Description { get; set; }
        public int? Amount { get; set; }
        public int? SanctionAmount { get; set; }
        public int ExpenseClaimTypeId { get; set; }
        [ForeignKey(nameof(ExpenseClaimTypeId))]
        public virtual ExpenseClaimType? ExpenseClaimType { get; set; }
    }
}
