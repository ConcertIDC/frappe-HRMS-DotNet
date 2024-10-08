using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Company;
using frappe_HRMS.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Employee
{
    public class Employee : BaseEntity
    {
        public string Series => $"HR-EMP-00{Id.ToString()}";
        public GenderEnum Gender { get; set; }
        public string? FirsetName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime DateofJoining { get; set; }
        public DateTime DateOfBirth { get; set; }
        public StatusEnum Status { get; set; }
        public SalutationEnum Salutation { get; set; }
        public int? UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company.Company? Company { get; set; }
        public int? EmployeeAttendanceLeavesId { get; set; }
        [ForeignKey(nameof(EmployeeAttendanceLeavesId))]
        public virtual EmployeeAttendanceLeaves? EmployeeAttendanceLeaves { get; set; }
        public int? DesignationId { get; set; }
        [ForeignKey(nameof(DesignationId))]
        public virtual Designation? Designation { get; set; }
        public int? BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }
        public int? EmployeeGradeId { get; set; }
        [ForeignKey(nameof(EmployeeGradeId))]
        public virtual EmployeeGrade? EmployeeGrade { get; set; }
        public int? EmploymentTypeId { get; set; }
        [ForeignKey(nameof(EmploymentTypeId))]
        public virtual EmploymentType? EmploymentType { get; set; }
        public string? ReportsTo { get; set; }
        public int? EmployeeAddressId { get; set; }
        [ForeignKey(nameof(EmployeeAddressId))]
        public virtual EmployeeAddress? EmployeeAddress { get; set; }
        public int? EmplyeeJoiningId { get; set; }
        [ForeignKey(nameof(EmplyeeJoiningId))]
        public virtual EmplyeeJoiningDetails? EmplyeeJoiningDetails { get; set; }
        public int? EmployeeSalaryId { get; set; }
        [ForeignKey(nameof(EmployeeSalaryId))]
        public virtual EmployeeSalary? EmployeeSalary { get; set; }
        public int? PersonalId { get; set; }
        [ForeignKey(nameof(PersonalId))]
        public virtual PersonalDetails? Personal { get; set; }
        public int? ProfileId { get; set; }
        [ForeignKey(nameof(ProfileId))]
        public virtual EmployeeProfile? Profile { get; set; }
        public int? ExitId { get; set; }
        [ForeignKey(nameof(ExitId))]
        public virtual Exit? Exit { get; set; }


    }
}
