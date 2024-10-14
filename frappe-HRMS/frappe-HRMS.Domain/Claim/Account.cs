using frappe_HRMS.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Domain.Claim
{
    public class Account : BaseEntity
    {
        public string? AccountName { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountType { get; set;}
        public decimal? Rate { get; set; }
        public string? BalanceMustbe { get; set; }
        public bool? Disable {  get; set; }
        public bool? IsGroup { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company.Company? Company { get; set; }
        public string? Currencey { get; set; }
    }
}
