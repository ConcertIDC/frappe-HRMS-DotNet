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
    public class EmployeeAdvance : BaseEntity
    {
        public string Series => $"HR-EAD-{DateTime.Now.Year}-00{Id.ToString()}";
        public DateTime? PostingDate { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company.Company? Company { get; set; }
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee.Employee? Employee { get; set; }
        public string? EmployeeName => Employee?.FirsetName;
        public string? Currency { get; set; } = "INR";
        public string? Purpose {get; set; }
        public decimal? AdvanceAmount { get; set; }
        public int? ModeOfPaymentId { get; set; }
        [ForeignKey(nameof(ModeOfPaymentId))]
        public virtual ModeOfPayment? ModeOfPayment { get; set; }
        public bool? RepayUnclaimedAmountfromSalary { get; set; }
    }
}
