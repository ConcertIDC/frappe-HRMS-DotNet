using frappe_HRMS.Domain.Base;

namespace frappe_HRMS.Domain.Projects
{
    public class ProjectType : BaseEntity
    {
        public string? ProjectTypeName { get; set; }
        public string? Description { get; set;}
    }
}
