using frappe_HRMS.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Domain.Projects
{
    public class ProjectTemplate : BaseEntity
    {
        public string? Name { get; set; }
        public int? ProjectTypeId { get; set; }
        [ForeignKey(nameof(ProjectTypeId))]
        public virtual ProjectType? ProjectType { get; set; }
        public virtual ICollection<Task>? Tasks { get; set; }
    }
}
