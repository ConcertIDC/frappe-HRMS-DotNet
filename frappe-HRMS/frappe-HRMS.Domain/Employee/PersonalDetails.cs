using frappe_HRMS.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Domain.Employee
{
    public class PersonalDetails : BaseEntity
    {
        public string? MaritalStatus { get; set; }
        public string? BloodGroup { get; set; }
        public string? FamilyBackground { get; set; }
        public string? HealthDetails { get; set; }
        public string? HealthInsuranceProvider { get; set; }
        //Passport Details   
        public string? PassportNumber { get; set;}
        public string? PlaceofIssue { get; set; }
        public DateTime? DateofIssue { get; set; }
        public DateTime? ValidUpto { get; set; }

    }
}
