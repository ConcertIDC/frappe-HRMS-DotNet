using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Company;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Employee
{
    public class NewJobApplicant : BaseEntity
    {
        [Required]
        public string? ApplicantName { get; set; }
        public int? NewJobOpeningId { get; set; }
        [ForeignKey(nameof(NewJobOpeningId))]
        public virtual NewJobOpening? NewJobOpening { get; set; }
        public string? EmailAddress { get; set; }
        public int? DesignationId { get; set; }
        [ForeignKey(nameof(DesignationId))]
        public virtual Designation? Designation { get; set; }
        public string? Status {  get; set; }
        public string? PhoneNumber { get; set; }
        public string? Country { get; set; }
        public string? ResumeLink { get; set; }
        public string? CoverLetter { get; set; }
        public string? Source { get; set; }
        [Range(0, 5, ErrorMessage = "ApplicantRating must be between 0 and 5.")]
        public decimal? ApplicantRating { get; set; }
        public string? Currency {  get; set; }
        public string? LowerRange { get; set; }
        public string? UpperRange { get; set; }
    }
}
