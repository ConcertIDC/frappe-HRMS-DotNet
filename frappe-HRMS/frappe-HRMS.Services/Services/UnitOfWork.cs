using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces;
using frappe_HRMS.Services.Interfaces.Attendance;
using frappe_HRMS.Services.Interfaces.Company;
using frappe_HRMS.Services.Interfaces.Employee;
using frappe_HRMS.Services.Interfaces.Leave;
using frappe_HRMS.Services.Services.Attendance;
using frappe_HRMS.Services.Services.Company;
using frappe_HRMS.Services.Services.Employee;
using frappe_HRMS.Services.Services.Leave;

namespace frappe_HRMS.Services.Services
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly HRMSDbContext _context;
        private bool _disposed;

        public IEmployeeRepository Employee { get; set; }
        public IBranchRepository Branch { get; set; }
        public IDepartmentRepository Department { get; set; }
        public IEmploymentTypeRepository EmploymentType { get; set; }
        public IEmployeeGradeRepository EmployeeGrade { get; set; }
        public IEmployeeGroupRepository EmployeeGroup { get; set; }
        public INewJobApplicantRepository NewJobApplicant { get; set; }
        public INewJobOpeningRepository NewJobOpening { get; set; }
        public ISignupRepository Signup { get; set; }
        public ICompanyRepository Company { get; set; }
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
        public IDesignationRepository Designation { get; set; }
        public IAttendanceRepository Attendance { get; set; }
        public IAttendanceRequestRepository AttendanceRequest { get; set; }
        public IShiftTypeRepository ShiftType { get; set; }
        public IEmployeeCheckinRepository EmployeeCheckin { get; set; }
        public UnitOfWork(HRMSDbContext context)
        {
            _context = context;
            Signup = new SignupRepository(_context);
            Company = new CompanyRepository(_context);
            Employee = new EmployeeRepository(_context);
            Branch = new BranchRepository(_context);
            Designation = new DesignationRepository(_context);
            Department = new DepartmentRepository(_context);
            EmploymentType = new EmploymentTypeRepository(_context);
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
            Attendance = new AttendanceRepository(_context);
            AttendanceRequest = new AttendanceRequestRepository(_context);
            ShiftType = new ShiftTypeRepository(_context);
            EmployeeCheckin = new EmployeeCheckinRepository(_context);
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
