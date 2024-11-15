using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Projects;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.TimeSheets
{
    public class TimeSheet : BaseEntity
    {
        public string Series => $"TS-{DateTime.Now.Year}-000{Id.ToString()}";
        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company.Company? Company { get; set; }
        public string? Customer {  get; set; }
        public int? ProjectId { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public virtual Project? Project { get; set; }
        public string? Currency {  get; set; }
        public decimal? ExchageRate { get; set; } = 1.000m;
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee.Employee? Employee { get; set; }
        public int? BillingDetailsId { get; set; }
        [ForeignKey(nameof(BillingDetailsId))]
        public virtual BillingDetails? BillingDetails { get; set; }
        public string? Note { get; set; }
        public virtual ICollection<TimeSheetList>? TimeSheets { get; set; }
    }
}
