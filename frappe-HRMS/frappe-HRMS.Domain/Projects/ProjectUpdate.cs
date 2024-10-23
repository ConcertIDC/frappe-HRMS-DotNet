using frappe_HRMS.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Domain.Projects
{
    public class ProjectUpdate : BaseEntity
    {
        public int? ProjectId { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public virtual Project? Project { get; set; }
        public bool? Sent { get; set; }
        public DateTime? Date { get; set; }
    }
}
