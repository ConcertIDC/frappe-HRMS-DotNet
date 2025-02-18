using frappe_HRMS.Domain.Base;
using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Infrastructure.Interfaces.Attendance;
using frappe_HRMS.Infrastructure.Interfaces.Claim;
using frappe_HRMS.Infrastructure.Interfaces.Company;
using frappe_HRMS.Infrastructure.Interfaces.Employee;
using frappe_HRMS.Infrastructure.Repositories.Company;
using frappe_HRMS.Infrastructure.Services;
using frappe_HRMS.Infrastructure.Services.Attendance;
using frappe_HRMS.Infrastructure.Services.Claim;
using frappe_HRMS.Infrastructure.Services.Employee;
using System.Collections.Concurrent;

namespace frappe_HRMS.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ConcurrentDictionary<Type, object> _repositories = new();
        protected HRMSDbContext _context;
        private bool _disposed;
        public IGenericRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return (IGenericRepository<T>)_repositories.GetOrAdd(typeof(T), new GenericRepository<T>(_context));
        }
        public IBranchRepository Branch { get; set; }
        public ICompanyRepository Company { get; set; }
        public IDepartmentRepository Department { get; set; }
        public IDesignationRepository Designation { get; set; }
        public IEmploymentTypeRepository EmploymentType { get; set; }
        public IAttendanceRepository Attendance { get; }
        public IAttendanceRequestRepository AttendanceRequest { get; }
        public IShiftTypeRepository ShiftType { get; }
        public IEmployeeCheckinRepository EmployeeCheckin { get; }
        public IHolidayListRepository HolidayList { get; }
        public ISignupRepository Signup { get; }
        public IExpenseClaimRepository ExpenseClaim { get; }
        public IAccountingDetailsRepository AccountingDetails { get; }
        public IExpensesRepository Expenses { get; }
        public IExpenseClaimTypeRepository ExpenseClaimType { get; }
        public ITravelRequestRepository TravelRequest { get; }
        public ITravelItineraryRepository TravelItinerary { get; }
        public IPurposeOfTravelRepository PurposeOfTravel { get; }
        public IAdvancePaymentRepository AdvancePayment { get; }
        public IAccountRepository Account { get; }
        public IEmployeeAdvanceRepository EmployeeAdvance { get; }
        public IModeOfPaymentReposiory ModeOfPayment { get; }
        public ITaxesAndChargesRepository TaxesAndCharges { get; }
        public IEmployeeRepository Employee { get; }
        public IEmployeeGroupRepository EmployeeGroup { get; }
        public IEmployeeGradeRepository EmployeeGrade { get; }
        public INewJobApplicantRepository NewJobApplicant { get; }
        public INewJobOpeningRepository NewJobOpening { get; }
        public IEmployeeAddressRepository EmployeeAddress { get; }
        public IEmployeeAttendanceRepository EmployeeAttendance { get; }
        public IEmployeeJoiningRepository EmployeeJoining { get; }
        public IEmployeeSalaryRepository EmployeeSalary { get; }
        public IExitRepository Exit { get; }
        public ICostCenterRepository CostCenter { get; }
        public IEmployeePersonalRepository PersonalDetails { get; }
        public IEmployeeProfileRepository EmployeeProfile { get; }
        public IEducationalQualificationRepository EducationalQualification { get; }
        public IPreviousWorkExperienceRepository PreviousWorkExperience { get; }
        public IEmployeeHistoryRepository EmployeeHistory { get; }
        public UnitOfWork(HRMSDbContext context)
        {
            _context = context;
            Signup = new SignupRepository(context);
            Branch = new BranchRepository(context);
            Company = new CompanyRepository(context);
            Department = new DepartmentRepository(context);
            Designation = new DesignationRepository(context);
            EmploymentType = new EmploymnetTypeRepository(context);
            Attendance = new AttendanceRepository(context);
            AttendanceRequest = new AttendanceRequestRepository(context);
            ShiftType = new ShiftTypeRepository(context);
            EmployeeCheckin = new EmployeeCheckinRepository(context);
            HolidayList = new HolidayListRepository(context);
            ExpenseClaim = new ExpenseClaimRepository(context);
            Account = new AccountRepository(context);
            AccountingDetails = new AccountingDetailsRepository(context);
            AdvancePayment = new AdvancePaymentRepository(context);
            EmployeeAdvance = new EmployeeAdvanceRepository(context);
            ExpenseClaimType = new ExpenseClaimTypeRepository(context);
            ModeOfPayment = new ModeOfPaymentReposiory(context);
            PurposeOfTravel = new PurposeOfTravelRepository(context);
            TaxesAndCharges = new TaxesAndChargesRepository(context);
            TravelItinerary = new TravelItineraryRepository(context);
            TravelRequest = new TravelRequestRepository(context);
            CostCenter = new CostCenterRepository(context);
            EducationalQualification = new EducationalQualificationRepository(context);
            Employee = new EmployeeRepository(context);
            EmployeeAddress = new EmployeeAddressRepository(context);
            EmployeeAttendance = new EmployeeAttendanceRepository(context);
            EmployeeGrade = new EmployeeGradeRepository(context);
            EmployeeGroup = new EmployeeGroupRepository(context);
            EmployeeHistory = new EmployeeHistoryRepository(context);
            EmployeeJoining = new EmployeeJoiningRepository(context);
            PersonalDetails = new EmployeePersonalRepository(context);
            EmployeeProfile = new EmployeeProfileRepository(context);
            EmployeeSalary = new EmployeeSalaryRepository(context);
            Exit = new ExitRepository(context);
            NewJobApplicant = new NewJobApplicantRepository(context);
            NewJobOpening = new NewJobOpeningRepository(context);
            PreviousWorkExperience = new PreviousWorkExperienceRepository(context);
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
