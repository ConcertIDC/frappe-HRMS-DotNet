using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Claim
{
    public class TravelItinerary : BaseEntity
    {
        public string? TravelFrom { get; set; }
        public string? TravelTo { get; set; }
        public string? ModeOfTravel { get; set; }
        public DateTime? DepartureDatetime { get; set; }
        public DateTime? ArrivalDatetime { get; set; }
        public string? MealPreference { get; set; }
        public bool? IsTravelAdvanceRequired { get; set; }
        public bool? IsLodgingRequired { get; set; }
        public string? OtherDetails { get; set; }
        public int? TravelRequestId { get; set; }
        [ForeignKey(nameof(TravelRequestId))]
        public virtual TravelRequest? TravelRequest { get; set; }
    }
}
