using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Employee;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace frappe_HRMS.Domain.Claim
{
    public class PurposeOfTravel : BaseEntity
    {
        public string? PurposeofTravel {  get; set; }     
    }
}
