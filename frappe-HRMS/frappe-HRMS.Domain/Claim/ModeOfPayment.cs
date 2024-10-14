using frappe_HRMS.Domain.Base;

namespace frappe_HRMS.Domain.Claim
{
    public class ModeOfPayment : BaseEntity
    {
        public string? PaymentMode { get; set; }
        public bool? Enabled { get; set; } = true;
        public string? Type { get; set; }
    }
}
