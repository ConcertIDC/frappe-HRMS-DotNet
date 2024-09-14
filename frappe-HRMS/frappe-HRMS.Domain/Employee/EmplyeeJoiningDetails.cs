using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Employee
{
    public class EmplyeeJoiningDetails : BaseEntity
    {
        public int? JobApplicantId { get; set; }
        [ForeignKey(nameof(JobApplicantId))]
        public virtual NewJobApplicant? JobApplicant { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public int? NoticeDays { get; set; }
        public DateTime? OfferDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public DateTime? DateOfRetirement { get; set; }
    }
}
