using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Claim
{
    public class CostingDetails : BaseEntity
    {
        public int ExpenseClaimTypeId { get; set; }
        [ForeignKey(nameof(ExpenseClaimTypeId))]
        public virtual ExpenseClaimType? ExpenseClaimType { get; set; }
        public decimal? SponseredAmount { get; set;}
        public decimal? FundedAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Comments {  get; set; }
    }
}
