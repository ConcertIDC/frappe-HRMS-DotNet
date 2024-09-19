﻿using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces;
using frappe_HRMS.Services.Interfaces.Company;
using frappe_HRMS.Services.Interfaces.Employee;
using frappe_HRMS.Services.Interfaces.Leave;
using frappe_HRMS.Services.Services.Company;
using frappe_HRMS.Services.Services.Employee;
using frappe_HRMS.Services.Services.Leave;

namespace frappe_HRMS.Services.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HRMSDbContext _context;
        public IEmployeeRepository EmployeeRepository { get; }
        public IBranchRepository BranchRepository { get; }
        public IDepartmentRepository DepartmentRepository { get; }
        public IEmploymentTypeRepository EmploymentTypeRepository { get; }
        public IEmployeeGradeRepository EmployeeGradeRepository { get; }
        public IEmployeeGroupRepository EmployeeGroupRepository { get; }
        public INewJobApplicantRepository NewJobApplicantRepository { get; }
        public INewJobOpeningRepository NewJobOpeningRepository { get; }
        public ISignupRepository SignupRepository { get; }
        public ICompanyRepository CompanyRepository { get; }
        public IEmployeeAddressRepository EmployeeAddressRepository { get; }
        public IEmployeeJoiningRepository EmployeeJoiningRepository { get; }
        public IEmployeeSalaryRepository EmployeeSalaryRepository { get; }
        public IExitRepository ExitRepository { get; }
        public IEmployeePersonalRepository EmployeePersonalRepository { get; }
        public ICostCenterRepository CostCenterRepository { get; }
        public IEmployeeProfileRepository EmployeeProfileRepository { get; }
        public IEducationalQualificationRepository EducationalQualificationRepository { get; }
        public IPreviousWorkExperienceRepository PreviousWorkExperienceRepository { get; }
        public IEmployeeHistoryRepository EmployeeHistoryRepository { get; }
        public ILeaveApplicationRepository LeaveApplicationRepository { get; }
        public ILeaveTypeRepository LeaveTypeRepository { get; }
        public ICompensatoryLeaveRequestRepository CompensatoryLeaveRequestRepository { get; }

        public UnitOfWork(HRMSDbContext context,
            ISignupRepository signupRepository,
            ICompanyRepository companyRepository,
            IEmployeeRepository employeeRepository,
            IBranchRepository branchRepository,
            IDepartmentRepository departmentRepository,
            IEmploymentTypeRepository employmentTypeRepository,
            IEmployeeGradeRepository employeeGradeRepository,
            IEmployeeGroupRepository employeeGroupRepository,
            INewJobApplicantRepository newJobApplicantRepository,
            INewJobOpeningRepository newJobOpeningRepository,
            IEmployeeAddressRepository employeeAddressRepository,
            IEmployeeJoiningRepository employeeJoiningRepository,
            IEmployeeSalaryRepository employeeSalaryRepository,
            ICostCenterRepository costCenterRepository,
            IExitRepository exitRepository,
            IEmployeePersonalRepository employeePersonalRepository,
            IEmployeeProfileRepository employeeProfileRepository,
            IEducationalQualificationRepository educationalQualificationRepository,
            IPreviousWorkExperienceRepository previousWorkExperienceRepository,
            IEmployeeHistoryRepository employeeHistoryRepository,
            ILeaveApplicationRepository leaveApplicationRepository,
            ILeaveTypeRepository leaveTypeRepository,
            ICompensatoryLeaveRequestRepository compensatoryLeaveRequestRepository)
        {
            _context = context;
            SignupRepository = signupRepository;
            CompanyRepository = companyRepository;
            EmployeeRepository = employeeRepository;
            BranchRepository = branchRepository;
            DepartmentRepository = departmentRepository;
            EmploymentTypeRepository = employmentTypeRepository;
            EmployeeGradeRepository = employeeGradeRepository;
            EmployeeGroupRepository = employeeGroupRepository;
            NewJobApplicantRepository = newJobApplicantRepository;
            NewJobOpeningRepository = newJobOpeningRepository;
            EmployeeAddressRepository = employeeAddressRepository;
            EmployeeJoiningRepository = employeeJoiningRepository;
            EmployeeSalaryRepository = employeeSalaryRepository;
            CostCenterRepository = costCenterRepository;
            ExitRepository = exitRepository;
            EmployeePersonalRepository = employeePersonalRepository;
            EmployeeProfileRepository = employeeProfileRepository;
            EducationalQualificationRepository = educationalQualificationRepository;
            PreviousWorkExperienceRepository = previousWorkExperienceRepository;
            EmployeeHistoryRepository = employeeHistoryRepository;
            LeaveApplicationRepository = leaveApplicationRepository;
            LeaveTypeRepository = leaveTypeRepository;
            CompensatoryLeaveRequestRepository = compensatoryLeaveRequestRepository;
        }


        public ISignupRepository Signup => new SignupRepository(_context);
        public ICompanyRepository Company => new CompanyRepository(_context);
        public IEmployeeRepository Employee => new EmployeeRepository(_context);
        public IBranchRepository Branch => new BranchRepository(_context);
        public IDepartmentRepository Department => new DepartmentRepository(_context);
        public IDesignationRepository Designation => new DesignationRepository(_context);
        public IEmploymentTypeRepository EmploymentType => new EmploymentTypeRepository(_context);
        public IEmployeeGroupRepository EmployeeGroup => new EmployeeGroupRepository(_context);
        public IEmployeeGradeRepository EmployeeGrade => new EmployeeGradeRepository(_context);
        public INewJobApplicantRepository NewJobApplicant => new NewJobApplicantRepository(_context);
        public INewJobOpeningRepository NewJobOpening => new NewJobOpeningRepository(_context);
        public IEmployeeAddressRepository EmployeeAddress => new EmployeeAddressRepository(_context);
        public IEmployeeJoiningRepository EmployeeJoining => new EmployeeJoiningRepository(_context);
        public IEmployeeSalaryRepository EmployeeSalary => new EmployeeSalaryRepository(_context);
        public IExitRepository Exit => new ExitRepository(_context);
        public ICostCenterRepository CostCenter => new CostCenterRepository(_context);
        public IEmployeePersonalRepository PersonalDetails => new EmployeePersonalRepository(_context);
        public IEmployeeProfileRepository EmployeeProfile => new EmployeeProfileRepository(_context);
        public IEducationalQualificationRepository EducationalQualification => new EducationalQualificationRepository(_context);
        public IPreviousWorkExperienceRepository PreviousWorkExperience => new PreviousWorkExperienceRepository(_context);
        public IEmployeeHistoryRepository EmployeeHistory => new EmployeeHistoryRepository(_context);
        public ILeaveApplicationRepository LeaveApplication => new LeaveApplicationRepository(_context);
        public ILeaveTypeRepository LeaveType => new LeaveTypeRepository(_context);
        public ICompensatoryLeaveRequestRepository CompensatoryLeaveRequest => new CompensatoryLeaveRequestRepository(_context);

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
