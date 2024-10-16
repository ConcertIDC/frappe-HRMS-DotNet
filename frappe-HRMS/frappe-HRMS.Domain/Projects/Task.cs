using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Projects
{
    public class Task : BaseEntity
    {
        public string Series => $"TASK-{DateTime.Now.Year}-000{Id.ToString()}";
        public string? Subject {  get; set; }
        public int? ProjectId { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public virtual Project? Project { get; set; }
        public int? ProjectTemplateId { get; set; }
        [ForeignKey(nameof(ProjectTemplateId))]
        public virtual ProjectTemplate? ProjectTemplate { get; set; }
    }
}
