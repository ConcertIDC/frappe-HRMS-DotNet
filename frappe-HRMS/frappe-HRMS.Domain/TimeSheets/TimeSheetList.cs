using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Projects;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.TimeSheets
{
    public class TimeSheetList : BaseEntity
    {
        public int? TimeSheetId { get; set; }
        [ForeignKey(nameof(TimeSheetId))]
        public virtual TimeSheet? TimeSheet { get; set; }
        public int? ActivityTypeId { get; set; }
        [ForeignKey(nameof(ActivityTypeId))]
        public virtual ActivityType? ActivityType { get; set; }
        public DateTime? FromTime { get; set; }
        public decimal? Hours { get; set; }
        public bool? IsBillable { get; set; }
        public int? ProjectId { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public virtual Project? Project { get; set; }
    }
}
