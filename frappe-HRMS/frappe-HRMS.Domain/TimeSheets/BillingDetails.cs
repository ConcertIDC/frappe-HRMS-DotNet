using frappe_HRMS.Domain.Base;

namespace frappe_HRMS.Domain.TimeSheets
{
    public class BillingDetails : BaseEntity
    {
        public decimal? BillingHours { get; set; }
        public decimal? TotalBillableAmount {get;set;}
        public decimal? TotalCostingAmount { get; set; }
    }
}
