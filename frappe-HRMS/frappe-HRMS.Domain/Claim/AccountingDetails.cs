using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Domain.Projects;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Claim
{
    public class AccountingDetails : BaseEntity
    {
        public DateTime? PostingDate { get; set; }
        public bool? IsPaid { get; set; }
        public DateTime? ClearanceDate { get; set; }
        public string? Remark { get; set; }
        public int? CostCenterId { get; set; }
        [ForeignKey(nameof(CostCenterId))]
        public virtual CostCenter? CostCenter { get; set; }
        public int? ProjectId { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public virtual Project? Project { get; set; }
    }
}
