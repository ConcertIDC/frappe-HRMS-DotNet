using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Employee;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Claim
{
    public class TaxesAndCharges : BaseEntity
    {
        public decimal? Rate { get; set; } = 0;
        public decimal? Amount { get; set; } = 0;
        public decimal? Total => Amount ?? 0;
        public string? Description { get; set; }
        public int? ProjectId { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public virtual Project? Project { get; set; }
        public int? CostCenterId { get; set; }
        [ForeignKey(nameof(CostCenterId))]
        public virtual CostCenter? CostCenter { get; set; }
        public int? AccountHeadId { get; set; }
        [ForeignKey(nameof(AccountHeadId))]
        public virtual Account? AccountHead { get; set; }
    }
}
