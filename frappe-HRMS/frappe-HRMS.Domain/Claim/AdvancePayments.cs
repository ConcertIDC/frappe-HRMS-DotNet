using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Claim
{
    public class AdvancePayments : BaseEntity
    {
        public int? EmployeeAdvanceId { get; set; }
        [ForeignKey(nameof(EmployeeAdvanceId))]
        public virtual EmployeeAdvance? EmployeeAdvance { get; set; }
        public decimal? AllocatedAmount { get; set; }
    }
}
