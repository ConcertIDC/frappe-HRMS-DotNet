using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Domain.Claim
{
    public class TravelRequest : BaseEntity
    {
        public string? TravelType { get; set; }
        public string? TravelFunding { get; set; }
        public string? DetailsofSponsor { get; set; }
        public int? PurposeOfTravelId { get; set; }
        [ForeignKey(nameof(PurposeOfTravelId))]
        public virtual PurposeOfTravel? PurposeOfTravel { get; set; }
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee.Employee? Employee { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company.Company? Company { get; set; }
        public string? ContactNumber { get; set; }
        public string? IdentificationDocumentNumber { get; set; }
        public string? ContactEmail { get; set; }
        public string? PassportNumber { get; set; }
        public string? AnyOtherDetails { get; set; }
        public int? CostCenterId { get; set; }
        [ForeignKey(nameof(CostCenterId))]
        public virtual CostCenter? CostCenter { get; set; }
        public string? NameOfOrganizer { get; set; }
        public string? AddressofOrganizer { get; set; }
        public string? OtherDetails { get; set; }
        public virtual ICollection<TravelItinerary>? TravelItinerary { get; set; }
        public virtual ICollection<CostingDetails>? CostingDetails { get; set; }

    }
}
