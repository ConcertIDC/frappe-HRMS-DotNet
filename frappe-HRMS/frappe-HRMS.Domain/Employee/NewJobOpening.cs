using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Company;
using frappe_HRMS.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Employee
{
    public class NewJobOpening : BaseEntity
    {
        public string NewJobOpeningId => $"HR-OPN-{DateTime.Now.Year}-00{Id.ToString()}";
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company.Company? Company { get; set; }
        public int? DesignationId { get; set; }
        [ForeignKey(nameof(DesignationId))]
        public virtual Designation? Designation { get; set; }
        public int? BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }
        public int? EmploymentTypeId { get; set; }
        [ForeignKey(nameof(EmploymentTypeId))]
        public virtual EmploymentType? EmploymentType { get; set; }
        public int? DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public virtual Department? Department { get; set; }
        public string? ReportsTo { get; set; }
        public DateTime? PostedOn { get; set; }
        public DateTime? ClosesOn {  get; set; }
        public JobOpeningStatus Status { get; set; }
        public bool? PublishOnWebsite { get;set; }
        public string? Route { get; set; }
        public string? JobApplicationRoute { get; set; }
        public string? Currency {  get; set; }
        public string? LowerRange {  get; set; }
        public string? UpperRange { get; set; }
        public bool? PublishSalaryRange {  get; set; }
        public string? SalaryPaidPer {  get; set; }
        public bool? PublishApplicationsReceived { get; set; }
    }
}
