using frappe_HRMS.Domain.Base;

namespace frappe_HRMS.Domain.TimeSheets
{
    public class ActivityType : BaseEntity
    {
        public string? TypeName {  get; set; }
        public decimal? DefaultCostingRate {  get; set; }
        public decimal? DefaultBillingRate { get; set; }
        public bool? IsDisabled { get; set; }
    }
}
