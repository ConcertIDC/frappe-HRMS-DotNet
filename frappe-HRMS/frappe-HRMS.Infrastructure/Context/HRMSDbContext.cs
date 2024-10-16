using frappe_HRMS.Domain;
using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Domain.Company;
using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Domain.Leave;
using frappe_HRMS.Domain.Projects;
using Microsoft.EntityFrameworkCore;

namespace frappe_HRMS.Infrastructure.Context
{
    public class HRMSDbContext : DbContext
    {
        public HRMSDbContext(DbContextOptions<HRMSDbContext>options):base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<EmploymentType> EmploymentType { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeGrade> EmployeeGrade { get; set; }
        public DbSet<EmployeeGroup> EmployeeGroup { get; set; }
        public DbSet<NewJobApplicant> NewJobApplicant { get; set; }
        public DbSet<NewJobOpening> NewJobOpening { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<EmplyeeJoiningDetails> EmplyeeJoiningDetails { get; set; }
        public DbSet<EmployeeSalary> EmployeeSalaries { get; set; }
        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<PersonalDetails> PersonalDetails { get; set; }
        public DbSet<Exit> Exits { get; set; }
        public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
        public DbSet<EmployeeHistory> EmployeeHistory { get; set; }
        public DbSet<PreviousWorkExperience> PreviousWorkExperience { get; set; }
        public DbSet<EducationalQualification> EducationalQualifications { get; set; }
        public DbSet<LeaveApplication> LeaveApplications { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<CompensatoryLeaveRequest> CompensatoryLeaveRequests { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<AttendanceRequest> AttendanceRequests { get; set; }
        public DbSet<EmployeeCheckin> EmployeeCheckin { get; set; }
        public DbSet<ShiftType> ShiftTypes { get; set; }
        public DbSet<ExpenseClaim> ExpenseClaims { get; set; }
        public DbSet<EmployeeAttendanceLeaves> EmployeeAttendanceLeaves { get; set;}
        public DbSet<HolidayList> HolidayList { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<ExpenseClaimType> ExpenseClaimTypes { get;set; }
        public DbSet<AccountingDetails> AccountingDetails { get; set; }       
        public DbSet<TravelRequest> TravelRequests { get; set; }
        public DbSet<PurposeOfTravel> PurposeOfTravels { get; set; }
        public DbSet<TravelItinerary> TravelItineraries { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<CostingDetails> CostingDetails { get; set; }
        public DbSet<AdvancePayments> AdvancePayments { get; set;}
        public DbSet<Account> Accounts { get; set; }
        public DbSet<EmployeeAdvance> EmployeeAdvances { get; set; }
        public DbSet<ModeOfPayment> ModeOfPayment { get; set; }
        public DbSet<TaxesAndCharges> TaxesAndCharges { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTemplate> ProjectTemplates { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<Domain.Projects.Task> Tasks { get; set; }
    }
}
