using frappe_HRMS.Services.Interfaces.Attendance;
using frappe_HRMS.Services.Interfaces.Claim;
using frappe_HRMS.Services.Interfaces.Employee;
using frappe_HRMS.Services.Interfaces.Leave;
using frappe_HRMS.Services.Interfaces.Projects;
using frappe_HRMS.Services.Interfaces.TimeSheet;
using frappe_HRMS.Services.Services.Employee;

namespace frappe_HRMS.Services.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //ISignupService Signup { get; }
        //ICompanyService Company { get; }
        IEmployeeRepository Employee { get; }
        //IBranchService Branch { get; }
        //IDesignationService Designation { get; }
        //IDepartmentService Department { get; }
        //IEmploymentTypeService EmploymentType { get; }
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
        //IAttendanceService Attendance { get; }
        //IAttendanceRequestService AttendanceRequest { get; }
        //IShiftTypeService ShiftType { get; }
        //IEmployeeCheckinService EmployeeCheckin { get; }
        //IHolidayListService HolidayList { get; }
        IEmployeeAttendanceRepository EmployeeAttendance { get; }
        
        IProjectRepository Project { get; }
        IProjectTemplateRepository ProjectTemplate { get; }
        IProjectTypeRepository ProjectType { get; }
        ITaskRepository Task { get; }
        IProjectUpdateRepository ProjectUpdate { get; }
        ITimeSheetRepository TimeSheet { get; }
        ITimeSheetListRepository TimeSheetList { get; }
        IActivityTypeRepository ActivityType { get; }
        IBillingDetailsRepository BillingDetails { get; }
        Task<int> Save();
    }
}
