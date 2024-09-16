using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Employee
{
    public class EmployeeProfile : BaseEntity
    {
        public string? BioCoverLetter { get; set; }
        public int? EducationalQualificationId { get; set; }
        [ForeignKey(nameof(EducationalQualificationId))]
        public virtual EducationalQualification? EducationalQualification { get; set; }
        public int? PreviousWorkExperienceId { get; set; }
        [ForeignKey(nameof(PreviousWorkExperienceId))]
        public virtual PreviousWorkExperience? PreviousWorkExperience { get; set; }
        public int? EmployeeHistoryId { get; set; }
        [ForeignKey(nameof(EmployeeHistoryId))]
        public virtual EmployeeHistory? EmployeeHistory { get; set; }
    }
}
