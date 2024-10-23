using frappe_HRMS.Services.Interfaces.Attendance;
using frappe_HRMS.Services.Interfaces.Claim;
using frappe_HRMS.Services.Interfaces.Company;
using frappe_HRMS.Services.Interfaces.Employee;
using frappe_HRMS.Services.Interfaces.Leave;
using frappe_HRMS.Services.Interfaces.Projects;
using frappe_HRMS.Services.Services.Employee;

namespace frappe_HRMS.Services.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ISignupRepository Signup { get; }
        ICompanyRepository Company { get; }
        IEmployeeRepository Employee { get; }
        IBranchRepository Branch { get; }
        IDesignationRepository Designation { get; }
        IDepartmentRepository Department { get; }
        IEmploymentTypeRepository EmploymentType { get; }
        IEmployeeGroupRepository EmployeeGroup { get; }
        IEmployeeGradeRepository EmployeeGrade { get; }
        INewJobApplicantRepository NewJobApplicant { get; }
        INewJobOpeningRepository NewJobOpening { get; }
        IEmployeeAddressRepository EmployeeAddress{ get; }
        IEmployeeJoiningRepository EmployeeJoining { get; }
        IEmployeeSalaryRepository EmployeeSalary { get; }
        IExitRepository Exit {  get; }
        ICostCenterRepository CostCenter {  get; }
        IEmployeePersonalRepository PersonalDetails {  get; }
        IEmployeeProfileRepository EmployeeProfile { get; }
        IEducationalQualificationRepository EducationalQualification { get; }
        IPreviousWorkExperienceRepository PreviousWorkExperience { get; }
        IEmployeeHistoryRepository EmployeeHistory { get; }
        ILeaveApplicationRepository LeaveApplication { get; }
        ILeaveTypeRepository LeaveType { get; }
        ICompensatoryLeaveRequestRepository CompensatoryLeaveRequest { get; }
        IAttendanceRepository Attendance { get; }
        IAttendanceRequestRepository AttendanceRequest { get; }
        IShiftTypeRepository ShiftType { get; }
        IEmployeeCheckinRepository EmployeeCheckin { get; }
        IHolidayListRepository HolidayList { get; }
        IEmployeeAttendanceRepository EmployeeAttendance { get; }
        IExpenseClaimRepository ExpenseClaim { get; }
        IAccountingDetailsRepository AccountingDetails { get; }
        IExpensesRepository Expenses { get; }
        IExpenseClaimTypeRepository ExpenseClaimType { get; }
        ITravelRequestRepository TravelRequest { get; }
        ITravelItineraryRepository TravelItinerary { get; }
        IPurposeOfTravelRepository PurposeOfTravel { get; }
        IAdvancePaymentRepository AdvancePayment { get; }
        IAccountRepository Account {  get; }
        IEmployeeAdvanceRepository EmployeeAdvance { get; }
        IModeOfPaymentReposiory ModeOfPayment {  get; }
        ITaxesAndChargesRepository TaxesAndCharges { get; }
        IProjectRepository Project { get; }
        IProjectTemplateRepository ProjectTemplate { get; }
        IProjectTypeRepository ProjectType { get; }
        ITaskRepository Task { get; }
        IProjectUpdateRepository ProjectUpdate { get; }
        Task<int> Save();
    }
}
