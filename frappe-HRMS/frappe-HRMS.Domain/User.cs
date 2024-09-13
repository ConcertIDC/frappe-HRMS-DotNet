using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Enum;

namespace frappe_HRMS.Domain
{
    public class User : BaseEntity
    {
        public string? SiteName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }       
        public string? Email { get; set; }
        public string? FullName => $"{FirstName} {LastName}";
        public string? Password { get; set; }
        public string? TimeZone { get; set; }
        public string? Language { get; set; }
        public string? Role { get; set; }
        public GenderEnum? Gender { get; set; }
        public string? Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Location { get; set; }
        public string? Intrests { get; set; }
        public string? Bio { get; set; }
    }
}
