using frappe_HRMS.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Domain.Employee
{
    public class EmployeeSalary : BaseEntity
    {
        public string? CTC {  get; set; }
        public int? CostCenterId { get; set; }
        [ForeignKey(nameof(CostCenterId))]
        public virtual CostCenter? CostCenter { get; set; }
        public string? SalaryCurrency {  get; set; }
        public string? PANNumber { get; set; }
        public string? SalaryMode { get; set; }
        public string? ProvidentFundAccount { get; set; }
    }
}
