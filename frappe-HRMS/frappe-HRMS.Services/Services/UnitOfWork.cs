using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces;
using frappe_HRMS.Services.Interfaces.Attendance;
using frappe_HRMS.Services.Interfaces.Claim;
using frappe_HRMS.Services.Interfaces.Company;
using frappe_HRMS.Services.Interfaces.Employee;
using frappe_HRMS.Services.Interfaces.Leave;
using frappe_HRMS.Services.Interfaces.Projects;
using frappe_HRMS.Services.Interfaces.TimeSheet;
using frappe_HRMS.Services.Services.Attendance;
using frappe_HRMS.Services.Services.Claim;
using frappe_HRMS.Services.Services.Company;
using frappe_HRMS.Services.Services.Employee;
using frappe_HRMS.Services.Services.Leave;
using frappe_HRMS.Services.Services.Projects;
using frappe_HRMS.Services.Services.TimeSheet;

namespace frappe_HRMS.Services.Services
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly HRMSDbContext _context;
        private bool _disposed;

        public IEmployeeRepository Employee { get; set; }
        /*public IBranchRepository Branch { get; set; }
        public IDepartmentRepository Department { get; set; }
        public IEmploymentTypeRepository EmploymentType { get; set; }*/
        public IEmployeeGradeRepository EmployeeGrade { get; set; }
        public IEmployeeGroupRepository EmployeeGroup { get; set; }
        public INewJobApplicantRepository NewJobApplicant { get; set; }
        public INewJobOpeningRepository NewJobOpening { get; set; }
        public ISignupService Signup { get; set; }
        /*public ICompanyRepository Company { get; set; }*/
        public IEmployeeAddressRepository EmployeeAddress { get; set; }
        public IEmployeeJoiningRepository EmployeeJoining { get; set; }
        public IEmployeeSalaryRepository EmployeeSalary { get; set; }
        public IExitRepository Exit { get; set; }
        public IEmployeePersonalRepository PersonalDetails { get; set; }
        public ICostCenterRepository CostCenter { get; set; }
        public IEmployeeProfileRepository EmployeeProfile { get; set; }
        public IEducationalQualificationRepository EducationalQualification { get; set; }
        public IPreviousWorkExperienceRepository PreviousWorkExperience { get; set; }
        public IEmployeeHistoryRepository EmployeeHistory { get; set; }
        public ILeaveApplicationRepository LeaveApplication { get; set; }
        public ILeaveTypeRepository LeaveType { get; set; }
        public ICompensatoryLeaveRequestRepository CompensatoryLeaveRequest { get; set; }
        /*public IDesignationRepository Designation { get; set; }*/
        public IAttendanceService Attendance { get; set; }
        public IAttendanceRequestService AttendanceRequest { get; set; }
        public IShiftTypeService ShiftType { get; set; }
        public IEmployeeCheckinService EmployeeCheckin { get; set; }
        public IHolidayListService HolidayList { get; set; }
        public IEmployeeAttendanceRepository EmployeeAttendance { get; set; }
        public IExpenseClaimService ExpenseClaim {get; set; }
        public IAccountingDetailsService AccountingDetails { get; set; }
        public IExpensesService Expenses { get; set; }
        public IExpenseClaimTypeService ExpenseClaimType { get; set; }
        public ITravelRequestService TravelRequest { get; set; }
        public ITravelItineraryService TravelItinerary { get; set; }
        public IPurposeOfTravelService PurposeOfTravel { get; set; }
        public IAdvancePaymentService AdvancePayment { get; set; }
        public IAccountService Account {  get; set; }
        public IEmployeeAdvanceService EmployeeAdvance { get; set; }
        public IModeOfPaymentService ModeOfPayment {  get; set; }
        public ITaxesAndChargesService TaxesAndCharges { get; set; }
        public IProjectRepository Project { get; set; }
        public IProjectTemplateRepository ProjectTemplate { get; set; }
        public IProjectTypeRepository ProjectType { get; set; }
        public ITaskRepository Task { get; set; }
        public IProjectUpdateRepository ProjectUpdate {  get; set; }
        public ITimeSheetRepository TimeSheet { get; set; }
        public ITimeSheetListRepository TimeSheetList { get; set; }
        public IActivityTypeRepository ActivityType { get; set; }
        public IBillingDetailsRepository BillingDetails { get; set; }
        public UnitOfWork(HRMSDbContext context)
        {
            _context = context;
            Employee = new EmployeeRepository(_context);
            EmployeeGrade = new EmployeeGradeRepository(_context);
            EmployeeGroup = new EmployeeGroupRepository(_context);
            NewJobApplicant = new NewJobApplicantRepository(_context);
            NewJobOpening = new NewJobOpeningRepository(_context);
            EmployeeAddress = new EmployeeAddressRepository(_context);
            EmployeeJoining = new EmployeeJoiningRepository(_context);
            EmployeeSalary = new EmployeeSalaryRepository(_context);
            CostCenter = new CostCenterRepository(_context);
            Exit = new ExitRepository(_context);
            PersonalDetails = new EmployeePersonalRepository(_context);
            EmployeeProfile = new EmployeeProfileRepository(_context);
            EducationalQualification = new EducationalQualificationRepository(_context);
            PreviousWorkExperience = new PreviousWorkExperienceRepository(_context);
            EmployeeHistory = new EmployeeHistoryRepository(_context);
            LeaveApplication = new LeaveApplicationRepository(_context);
            LeaveType = new LeaveTypeRepository(_context);
            CompensatoryLeaveRequest = new CompensatoryLeaveRequestRepository(_context);
            Project = new ProjectRepository(_context);
            ProjectTemplate = new ProjectTemplateRepository(_context);
            ProjectType = new ProjectTypeRepository(_context);
            Task = new TaskRepository(_context);
            ProjectUpdate = new ProjectUpdateRepository(_context);
            TimeSheetList = new TimeSheetListRepository(_context);
            TimeSheet = new TimeSheetRepository(_context);
            ActivityType = new ActivityTypeRepository(_context);
            BillingDetails = new BillingDetailsRepository(_context);
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
