﻿using frappe_HRMS.Services.Interfaces.Company;
using frappe_HRMS.Services.Interfaces.Employee;
using frappe_HRMS.Services.Interfaces.Leave;
using frappe_HRMS.Services.Services.Employee;

namespace frappe_HRMS.Services.Interfaces
{
    public interface IUnitOfWork
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
        Task<int> Save();
    }
}
