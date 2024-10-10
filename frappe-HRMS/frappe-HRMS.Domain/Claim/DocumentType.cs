using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Claim
{
    public class DocumentType : BaseEntity
    {
        public string? IdentificationDocumentType { get; set; }
        public int? TravelRequestId { get; set; }
        [ForeignKey(nameof(TravelRequestId))]
        public virtual TravelRequest? TravelRequest { get; set; }
    }
}
