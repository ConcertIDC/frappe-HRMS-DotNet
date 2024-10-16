using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Company;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace frappe_HRMS.Domain.Projects
{
    public class Project : BaseEntity
    {
        public string Series => $"PROJ-0000{Id.ToString()}";
        public string? ProjectName { get; set; }
        public string? Status { get; set; }
        public DateTime? ExpectedStartDate { get; set; }
        public DateTime? ExpectedEndDate { get; set; }
        public string? Priority { get; set; }
        public string? IsActive { get; set; }
        public string? CompleteMethod { get; set; }
        public int? DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public virtual Department? Department { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company.Company? Company { get; set; }
        public int? ProjectTemplateId { get; set; }
        [ForeignKey(nameof(ProjectTemplateId))]
        public virtual ProjectTemplate? ProjectTemplate { get; set; }
        public int? ProjectTypeId { get; set; }
        [ForeignKey(nameof(ProjectTypeId))]
        public virtual ProjectType? ProjectType { get; set; }
    }
}
