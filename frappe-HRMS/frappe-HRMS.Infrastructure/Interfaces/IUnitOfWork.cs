using frappe_HRMS.Domain.Base;
using frappe_HRMS.Infrastructure.Interfaces.Attendance;
using frappe_HRMS.Infrastructure.Interfaces.Claim;
using frappe_HRMS.Infrastructure.Interfaces.Company;

namespace frappe_HRMS.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : BaseEntity;
        IBranchRepository Branch { get; }
        ICompanyRepository Company { get; }
        IDesignationRepository Designation { get; }
        IDepartmentRepository Department { get; }
        IEmploymentTypeRepository EmploymentType { get; }
        IAttendanceRepository Attendance { get; }
        IAttendanceRequestRepository AttendanceRequest { get; }
        IShiftTypeRepository ShiftType { get; }
        IEmployeeCheckinRepository EmployeeCheckin { get; }
        IHolidayListRepository HolidayList { get; }
        ISignupRepository Signup { get; }
        IExpenseClaimRepository ExpenseClaim { get; }
        IAccountingDetailsRepository AccountingDetails { get; }
        IExpensesRepository Expenses { get; }
        IExpenseClaimTypeRepository ExpenseClaimType { get; }
        ITravelRequestRepository TravelRequest { get; }
        ITravelItineraryRepository TravelItinerary { get; }
        IPurposeOfTravelRepository PurposeOfTravel { get; }
        IAdvancePaymentRepository AdvancePayment { get; }
        IAccountRepository Account { get; }
        IEmployeeAdvanceRepository EmployeeAdvance { get; }
        IModeOfPaymentReposiory ModeOfPayment { get; }
        ITaxesAndChargesRepository TaxesAndCharges { get; }
        Task<int> Save();
    }
}
