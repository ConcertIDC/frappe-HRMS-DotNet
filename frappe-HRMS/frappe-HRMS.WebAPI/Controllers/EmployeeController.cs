using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Services.Interfaces.Employee;
using frappe_HRMS.Services.Services.Employee;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IEmployeeService employeeService,IEmployeeGradeService employeeGradeService,IEmployeeGroupService employeeGroupService,
        INewJobApplicantService newJobApplicantService,INewJobOpeningService newJobOpeningService,IEmployeeAddressService employeeAddressService,
        IEmployeeJoiningService employeeJoiningService,ICostCenterService costCenterService,IEmployeeSalaryService employeeSalaryService,IExitService exitService,
        IEmployeePersonalService employeePersonalService,IEmployeeProfileService employeeProfileService,IEmployeeHistoryService employeeHistoryService,
        IEmployeeAttendanceService employeeAttendanceService,IEducationalQualificationService educationalQualificationService,IPreviousWorkExperienceService previousWorkExperienceService) : ControllerBase
    {
        [HttpPost("CreateEmployee")]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            var result = await employeeService.AddAsync(employee);
            return result;
        }

        [HttpGet("GetAllEmployees")]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees()
        {
            var result = await employeeService.GetAllEmployees();
            return Ok(result);
        }
        [HttpGet("GetEmployeeById")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int id)
        {
            try
            {
                var result = employeeService.GetEmployeeById(id); 
                if (result == null)
                {
                    return NotFound($"Employee with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpPost("EditEmployee")]
        public async Task<ActionResult<Employee>> EditEmployee(Employee employee)
        {
            var result = await employeeService.Update(employee);
            return result;
        }
        [HttpPost("CreateEmployeeGroup")]
        public async Task<ActionResult<EmployeeGroup>> CreateEmployeeGroup(EmployeeGroup employeeGroup)
        {
            var result = await employeeGroupService.AddAsync(employeeGroup);
            return result;
        }
        [HttpGet("GetEmployeeGroupById")]
        public async Task<ActionResult<EmployeeGroup>> GetEmployeGroupeById(int id)
        {
            try
            {
                var result = employeeGroupService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee group with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAllGroups")]
        public async Task<ActionResult<List<EmployeeGroup>>> GetAllGroups()
        {
            var result = await employeeGroupService.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEmployeeGroup")]
        public async Task<ActionResult<EmployeeGroup>> EditEmployeeGroup(EmployeeGroup employeeGroup)
        {
            var result = await employeeGroupService.Update(employeeGroup);
            return result;
        }
        [HttpPost("CreateEmployeeGrade")]
        public async Task<ActionResult<EmployeeGrade>> CreateEmployeeGrade(EmployeeGrade employeeGrade)
        {
            var result = await employeeGradeService.AddAsync(employeeGrade);
            return result;
        }
        [HttpGet("GetEmployeeGradeById")]
        public async Task<ActionResult<EmployeeGrade>> GetEmployeeGradeById(int id)
        {
            try
            {
                var result = employeeGradeService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee Grade with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAllEmployeeGrades")]
        public async Task<ActionResult<List<EmployeeGrade>>> GetAllEmployeeGrades()
        {
            var result = await employeeGradeService.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEmployeeGrade")]
        public async Task<ActionResult<EmployeeGrade>> EditEmployeeGrade(EmployeeGrade employeeGrade)
        {
            var result = await employeeGradeService.Update(employeeGrade);
            return result;
        }

        [HttpPost("CreateJobApplicant")]
        public async Task<ActionResult<NewJobApplicant>> CreateJobApplicant(NewJobApplicant jobApplicant)
        {
            var result = await newJobApplicantService.AddAsync(jobApplicant);
            return result;
        }

        [HttpGet("GetAllJobApplicants")]
        public async Task<ActionResult<List<NewJobApplicant>>> GetAllJobApplicants()
        {
            var result = await newJobApplicantService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetJobApplicantById")]
        public async Task<ActionResult<NewJobApplicant>> GetJobApplicantById(int id)
        {
            try
            {
                var result = newJobApplicantService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("EditJobApplicant")]
        public async Task<ActionResult<NewJobApplicant>> EditJobApplicant(NewJobApplicant jobApplicant)
        {
            var result = await newJobApplicantService.Update(jobApplicant);
            return result;
        }
        [HttpPost("CreateJobOpening")]
        public async Task<ActionResult<NewJobOpening>> CreateJobOpening(NewJobOpening jobOpening)
        {
            var result = await newJobOpeningService.AddAsync(jobOpening);
            return result;
        }

        [HttpGet("GetAllJobOpenings")]
        public async Task<ActionResult<List<NewJobOpening>>> GetAllJobOpenings()
        {
            var result = await newJobOpeningService.GetAll();
            return Ok(result);
        }

        [HttpPost("EditJobOpening")]
        public async Task<ActionResult<NewJobOpening>> EditJobOpening(NewJobOpening jobOpening)
        {
            var result = await newJobOpeningService.Update(jobOpening);
            return result;
        }
        [HttpPost("CreateEmployeeAddress")]
        public async Task<ActionResult<EmployeeAddress>> CreateEmployeeAddress(EmployeeAddress address)
        {
            var result = await employeeAddressService.AddAsync(address);
            return result;
        }

        [HttpGet("GetAllAddresses")]
        public async Task<ActionResult<List<EmployeeAddress>>> GetAllAddresses()
        {
            var result = await employeeAddressService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetEmployeeAddressById")]
        public async Task<ActionResult<EmployeeAddress>> GetEmployeeAddressById(int id)
        {
            try
            {
                var result = employeeAddressService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("EditEmployeeAddress")]
        public async Task<ActionResult<EmployeeAddress>> EditEmployeeAddress(EmployeeAddress address)
        {
            var result = await employeeAddressService.Update(address);
            return result;
        }
        [HttpPost("CreateEmplyeeJoining")]
        public async Task<ActionResult<EmplyeeJoiningDetails>> CreateEmplyeeJoining(EmplyeeJoiningDetails joiningDetails)
        {
            var result = await employeeJoiningService.AddAsync(joiningDetails);
            return result;
        }
        [HttpGet("GetEmplyeeJoiningDetailsById")]
        public async Task<ActionResult<EmplyeeJoiningDetails>> EmplyeeJoiningDetailsById(int id)
        {
            try
            {
                var result = employeeJoiningService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee joining details with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAllEmplyeeJoiningDetails")]
        public async Task<ActionResult<List<EmplyeeJoiningDetails>>> GetAllEmplyeeJoiningDetails()
        {
            var result = await employeeJoiningService.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEmplyeeJoiningDetails")]
        public async Task<ActionResult<EmplyeeJoiningDetails>> EditEmplyeeJoiningDetails(EmplyeeJoiningDetails joiningDetails)
        {
            var result = await employeeJoiningService.Update(joiningDetails);
            return result;
        }
        [HttpPost("CreateEmployeeSalary")]
        public async Task<ActionResult<EmployeeSalary>> CreateEmployeeSalary(EmployeeSalary employeeSalary)
        {
            var result = await employeeSalaryService.AddAsync(employeeSalary);
            return result;
        }
        [HttpGet("GetEmployeeSalaryById")]
        public async Task<ActionResult<EmployeeSalary>> GetEmployeeSalaryById(int id)
        {
            try
            {
                var result = employeeSalaryService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee Salary with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAllEmployeeSalary")]
        public async Task<ActionResult<List<EmployeeSalary>>> GetAllEmployeeSalary()
        {
            var result = await employeeSalaryService.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEmployeeSalary")]
        public async Task<ActionResult<EmployeeSalary>> EditEmployeeSalary(EmployeeSalary employeeSalary)
        {
            var result = await employeeSalaryService.Update(employeeSalary);
            return result;
        }
        [HttpPost("CreateCostCenter")]
        public async Task<ActionResult<CostCenter>> CreateCostCenter(CostCenter costCenter)
        {
            var result = await costCenterService.AddAsync(costCenter);
            return result;
        }
        [HttpGet("GetCostCenterById")]
        public async Task<ActionResult<CostCenter>> GetCostCenterById(int id)
        {
            try
            {
                var result = costCenterService.GetById(id);
                if (result == null)
                {
                    return NotFound($"CostCenter with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAllCostCenters")]
        public async Task<ActionResult<List<CostCenter>>> GetAllCostCenters()
        {
            var result = await costCenterService.GetAll();
            return Ok(result);
        }
        [HttpPost("EditCostCenter")]
        public async Task<ActionResult<CostCenter>> EditCostCenter(CostCenter costCenter)
        {
            var result = await costCenterService.Update(costCenter);
            return result;
        }

        [HttpPost("CreateExit")]
        public async Task<ActionResult<Exit>> CreateExit(Exit exit)
        {
            var result = await exitService.AddAsync(exit);
            return result;
        }
        [HttpGet("GetExitById")]
        public async Task<ActionResult<Exit>> GetExitById(int id)
        {
            try
            {
                var result = exitService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee Exit with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("EditExit")]
        public async Task<ActionResult<Exit>> EditExit(Exit exit)
        {
            var result = await exitService.Update(exit);
            return result;
        }
        [HttpPost("CreatePersonalDetails")]
        public async Task<ActionResult<PersonalDetails>> CreatePersonalDetails(PersonalDetails personalDetails)
        {
            var result = await employeePersonalService.AddAsync(personalDetails);
            return result;
        }

        [HttpGet("GetAllPersonalDetails")]
        public async Task<ActionResult<List<PersonalDetails>>> GetAllPersonalDetails()
        {
            var result = await employeePersonalService.GetAll();
            return Ok(result);
        }
        [HttpPost("EditPersonalDetails")]
        public async Task<ActionResult<PersonalDetails>> EditPersonalDetails(PersonalDetails personalDetails)
        {
            var result = await employeePersonalService.Update(personalDetails);
            return result;
        }
        [HttpGet("GetPersonalDetailById")]
        public async Task<ActionResult<PersonalDetails>> GetPersonalDetailById(int id)
        {
            try
            {
                var result = employeePersonalService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee Personal Detail with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("CreateEmployeeProfile")]
        public async Task<ActionResult<EmployeeProfile>> CreateEmployeeProfile(EmployeeProfile profile)
        {
            var result = await employeeProfileService.AddAsync(profile);
            return result;
        }

        [HttpGet("GetAllEmployeeProfiles")]
        public async Task<ActionResult<List<EmployeeProfile>>> GetAllEmployeeProfiles()
        {
            var result = await employeeProfileService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetEmployeeProfileById")]
        public async Task<ActionResult<EmployeeProfile>> GetEmployeeProfileById(int id)
        {
            try
            {
                var result = employeeProfileService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee Profile with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("EditEmployeeProfile")]
        public async Task<ActionResult<EmployeeProfile>> EditEmployeeProfile(EmployeeProfile profile)
        {
            var result = await employeeProfileService.Update(profile);
            return result;
        }
        [HttpPost("CreateEducationalQualification")]
        public async Task<ActionResult<EducationalQualification>> CreateEducationalQualification(EducationalQualification qualification)
        {
            var result = await educationalQualificationService.AddAsync(qualification);
            return result;
        }

        [HttpGet("GetAllEducationalQualifications")]
        public async Task<ActionResult<List<EducationalQualification>>> GetAllEducationalQualifications()
        {
            var result = await educationalQualificationService.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEducationalQualification")]
        public async Task<ActionResult<EducationalQualification>> EditEducationalQualification(EducationalQualification qualification)
        {
            var result = await educationalQualificationService.Update(qualification);
            return result;
        }
        [HttpGet("GetEditEducationalQualificationById")]
        public async Task<ActionResult<EducationalQualification>> GetEditEducationalQualificationById(int id)
        {
            try
            {
                var result = educationalQualificationService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee Educational Qualification with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("CreatePreviousWorkExperience")]
        public async Task<ActionResult<PreviousWorkExperience>> CreatePreviousWorkExperience(PreviousWorkExperience experience)
        {
            var result = await previousWorkExperienceService.AddAsync(experience);
            return result;
        }

        [HttpGet("GetAllPreviousWorkExperiences")]
        public async Task<ActionResult<List<PreviousWorkExperience>>> GetAllPreviousWorkExperiences()
        {
            var result = await previousWorkExperienceService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetPreviousWorkExperienceById")]
        public async Task<ActionResult<PreviousWorkExperience>> GetPreviousWorkExperienceById(int id)
        {
            try
            {
                var result = previousWorkExperienceService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee Previous WorkExperience with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("EditPreviousWorkExperience")]
        public async Task<ActionResult<PreviousWorkExperience>> EditPreviousWorkExperience(PreviousWorkExperience experience)
        {
            var result = await previousWorkExperienceService.Update(experience);
            return result;
        }
        [HttpPost("CreateEmployeeAttendance")]
        public async Task<ActionResult<EmployeeAttendanceLeaves>> CreateEmployeeAttendance(EmployeeAttendanceLeaves attendanceLeaves)
        {
            var result = await employeeAttendanceService.AddAsync(attendanceLeaves);
            return result;
        }
        [HttpGet("GetEmployeeAttendanceById")]
        public async Task<ActionResult<EmployeeAttendanceLeaves>> GetEmployeeAttendanceById(int id)
        {
            try
            {
                var result = employeeAttendanceService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employee Attendance with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAllEmployeeAttendances")]
        public async Task<ActionResult<List<EmployeeAttendanceLeaves>>> GetAllEmployeeAttendances()
        {
            var result = await employeeAttendanceService.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEmployeeAttendance")]
        public async Task<ActionResult<EmployeeAttendanceLeaves>> EditEmployeeAttendance(EmployeeAttendanceLeaves attendanceLeaves)
        {
            var result = await employeeAttendanceService.Update(attendanceLeaves);
            return result;
        }
    }
}
