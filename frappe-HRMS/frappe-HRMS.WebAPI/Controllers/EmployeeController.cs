using frappe_HRMS.Domain.Company;
using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Services.Interfaces;
using frappe_HRMS.Services.Services.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IUnitOfWork _unitOfWork) : ControllerBase
    {
        [HttpPost("CreateEmployee")]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            var result = await _unitOfWork.Employee.AddAsync(employee);
            return result;
        }

        [HttpGet("GetAllEmployees")]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees()
        {
            var result = await _unitOfWork.Employee.GetAll();
            return Ok(result);
        }
        [HttpGet("GetEmployeeById")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int id)
        {
            try
            {
                var result = _unitOfWork.Employee.GetEmployeeById(id); 
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
            var result = _unitOfWork.Employee.Update(employee);
            await _unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateEmployeeGroup")]
        public async Task<ActionResult<EmployeeGroup>> CreateEmployeeGroup(EmployeeGroup employeeGroup)
        {
            var result = await _unitOfWork.EmployeeGroup.AddAsync(employeeGroup);
            return result;
        }
        [HttpGet("GetEmployeeGroupById")]
        public async Task<ActionResult<EmployeeGroup>> GetEmployeGroupeById(int id)
        {
            try
            {
                var result = _unitOfWork.EmployeeGroup.GetById(id);
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
            var result = await _unitOfWork.EmployeeGroup.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEmployeeGroup")]
        public async Task<ActionResult<EmployeeGroup>> EditEmployeeGroup(EmployeeGroup employeeGroup)
        {
            var result = _unitOfWork.EmployeeGroup.Update(employeeGroup);
            await _unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateEmployeeGrade")]
        public async Task<ActionResult<EmployeeGrade>> CreateEmployeeGrade(EmployeeGrade employeeGrade)
        {
            var result = await _unitOfWork.EmployeeGrade.AddAsync(employeeGrade);
            return result;
        }
        [HttpGet("GetEmployeeGradeById")]
        public async Task<ActionResult<EmployeeGrade>> GetEmployeeGradeById(int id)
        {
            try
            {
                var result = _unitOfWork.EmployeeGrade.GetById(id);
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
            var result = await _unitOfWork.EmployeeGrade.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEmployeeGrade")]
        public async Task<ActionResult<EmployeeGrade>> EditEmployeeGrade(EmployeeGrade employeeGrade)
        {
            var result = _unitOfWork.EmployeeGrade.Update(employeeGrade);
            await _unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateEmploymentType")]
        public async Task<ActionResult<EmploymentType>> CreateEmploymentType(EmploymentType employmentType)
        {
            var result = await _unitOfWork.EmploymentType.AddAsync(employmentType);
            return result;
        }

        [HttpGet("GetAllemploymentTypes")]
        public async Task<ActionResult<List<EmploymentType>>> GetAllemploymentTypes()
        {
            var result = await _unitOfWork.EmploymentType.GetAll();
            return Ok(result);
        }
        [HttpGet("GetEmploymentTypeById")]
        public async Task<ActionResult<EmploymentType>> GetEmploymentTypeById(int id)
        {
            try
            {
                var result = _unitOfWork.EmploymentType.GetById(id);
                if (result == null)
                {
                    return NotFound($"Employment Type with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("EditEmploymentType")]
        public async Task<ActionResult<EmploymentType>> EditEmploymentType(EmploymentType employmentType)
        {
            var result = _unitOfWork.EmploymentType.Update(employmentType);
            await _unitOfWork.Save();
            return result;
        }


        [HttpPost("CreateJobApplicant")]
        public async Task<ActionResult<NewJobApplicant>> CreateJobApplicant(NewJobApplicant jobApplicant)
        {
            var result = await _unitOfWork.NewJobApplicant.AddAsync(jobApplicant);
            return result;
        }

        [HttpGet("GetAllJobApplicants")]
        public async Task<ActionResult<List<NewJobApplicant>>> GetAllJobApplicants()
        {
            var result = await _unitOfWork.NewJobApplicant.GetAll();
            return Ok(result);
        }
        [HttpGet("GetJobApplicantById")]
        public async Task<ActionResult<NewJobApplicant>> GetJobApplicantById(int id)
        {
            try
            {
                var result = _unitOfWork.NewJobApplicant.GetById(id);
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
            var result = _unitOfWork.NewJobApplicant.Update(jobApplicant);
            await _unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateJobOpening")]
        public async Task<ActionResult<NewJobOpening>> CreateJobOpening(NewJobOpening jobOpening)
        {
            var result = await _unitOfWork.NewJobOpening.AddAsync(jobOpening);
            return result;
        }

        [HttpGet("GetAllJobOpenings")]
        public async Task<ActionResult<List<NewJobOpening>>> GetAllJobOpenings()
        {
            var result = await _unitOfWork.NewJobOpening.GetAll();
            return Ok(result);
        }

        [HttpPost("EditJobOpening")]
        public async Task<ActionResult<NewJobOpening>> EditJobOpening(NewJobOpening jobOpening)
        {
            var result = _unitOfWork.NewJobOpening.Update(jobOpening);
            await _unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateEmployeeAddress")]
        public async Task<ActionResult<EmployeeAddress>> CreateEmployeeAddress(EmployeeAddress address)
        {
            var result = await _unitOfWork.EmployeeAddress.AddAsync(address);
            return result;
        }

        [HttpGet("GetAllAddresses")]
        public async Task<ActionResult<List<EmployeeAddress>>> GetAllAddresses()
        {
            var result = await _unitOfWork.EmployeeAddress.GetAll();
            return Ok(result);
        }
        [HttpGet("GetEmployeeAddressById")]
        public async Task<ActionResult<EmployeeAddress>> GetEmployeeAddressById(int id)
        {
            try
            {
                var result = _unitOfWork.EmployeeAddress.GetById(id);
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
            var result = _unitOfWork.EmployeeAddress.Update(address);
            await _unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateEmplyeeJoining")]
        public async Task<ActionResult<EmplyeeJoiningDetails>> CreateEmplyeeJoining(EmplyeeJoiningDetails joiningDetails)
        {
            var result = await _unitOfWork.EmployeeJoining.AddAsync(joiningDetails);
            return result;
        }
        [HttpGet("GetEmplyeeJoiningDetailsById")]
        public async Task<ActionResult<EmplyeeJoiningDetails>> EmplyeeJoiningDetailsById(int id)
        {
            try
            {
                var result = _unitOfWork.EmployeeJoining.GetById(id);
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
            var result = await _unitOfWork.EmployeeJoining.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEmplyeeJoiningDetails")]
        public async Task<ActionResult<EmplyeeJoiningDetails>> EditEmplyeeJoiningDetails(EmplyeeJoiningDetails joiningDetails)
        {
            var result = _unitOfWork.EmployeeJoining.Update(joiningDetails);
            await _unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateEmployeeSalary")]
        public async Task<ActionResult<EmployeeSalary>> CreateEmployeeSalary(EmployeeSalary employeeSalary)
        {
            var result = await _unitOfWork.EmployeeSalary.AddAsync(employeeSalary);
            return result;
        }
        [HttpGet("GetEmployeeSalaryById")]
        public async Task<ActionResult<EmployeeSalary>> GetEmployeeSalaryById(int id)
        {
            try
            {
                var result = _unitOfWork.EmployeeSalary.GetById(id);
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
            var result = await _unitOfWork.EmployeeSalary.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEmployeeSalary")]
        public async Task<ActionResult<EmployeeSalary>> EditEmployeeSalary(EmployeeSalary employeeSalary)
        {
            var result = _unitOfWork.EmployeeSalary.Update(employeeSalary);
            await _unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateCostCenter")]
        public async Task<ActionResult<CostCenter>> CreateCostCenter(CostCenter costCenter)
        {
            var result = await _unitOfWork.CostCenter.AddAsync(costCenter);
            return result;
        }
        [HttpGet("GetCostCenterById")]
        public async Task<ActionResult<CostCenter>> GetCostCenterById(int id)
        {
            try
            {
                var result = _unitOfWork.CostCenter.GetById(id);
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
            var result = await _unitOfWork.CostCenter.GetAll();
            return Ok(result);
        }
        [HttpPost("EditCostCenter")]
        public async Task<ActionResult<CostCenter>> EditCostCenter(CostCenter costCenter)
        {
            var result = _unitOfWork.CostCenter.Update(costCenter);
            await _unitOfWork.Save();
            return result;
        }

        [HttpPost("CreateExit")]
        public async Task<ActionResult<Exit>> CreateExit(Exit exit)
        {
            var result = await _unitOfWork.Exit.AddAsync(exit);
            return result;
        }
        [HttpGet("GetExitById")]
        public async Task<ActionResult<Exit>> GetExitById(int id)
        {
            try
            {
                var result = _unitOfWork.Exit.GetById(id);
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
            var result = _unitOfWork.Exit.Update(exit);
            await _unitOfWork.Save();
            return result;
        }
        [HttpPost("CreatePersonalDetails")]
        public async Task<ActionResult<PersonalDetails>> CreatePersonalDetails(PersonalDetails personalDetails)
        {
            var result = await _unitOfWork.PersonalDetails.AddAsync(personalDetails);
            return result;
        }

        [HttpGet("GetAllPersonalDetails")]
        public async Task<ActionResult<List<PersonalDetails>>> GetAllPersonalDetails()
        {
            var result = await _unitOfWork.PersonalDetails.GetAll();
            return Ok(result);
        }
        [HttpPost("EditPersonalDetails")]
        public async Task<ActionResult<PersonalDetails>> EditPersonalDetails(PersonalDetails personalDetails)
        {
            var result = _unitOfWork.PersonalDetails.Update(personalDetails);
            await _unitOfWork.Save();
            return result;
        }
        [HttpGet("GetPersonalDetailById")]
        public async Task<ActionResult<PersonalDetails>> GetPersonalDetailById(int id)
        {
            try
            {
                var result = _unitOfWork.PersonalDetails.GetById(id);
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
            var result = await _unitOfWork.EmployeeProfile.AddAsync(profile);
            return result;
        }

        [HttpGet("GetAllEmployeeProfiles")]
        public async Task<ActionResult<List<EmployeeProfile>>> GetAllEmployeeProfiles()
        {
            var result = await _unitOfWork.EmployeeProfile.GetAll();
            return Ok(result);
        }
        [HttpGet("GetEmployeeProfileById")]
        public async Task<ActionResult<EmployeeProfile>> GetEmployeeProfileById(int id)
        {
            try
            {
                var result = _unitOfWork.EmployeeProfile.GetById(id);
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
            var result = _unitOfWork.EmployeeProfile.Update(profile);
            await _unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateEducationalQualification")]
        public async Task<ActionResult<EducationalQualification>> CreateEducationalQualification(EducationalQualification qualification)
        {
            var result = await _unitOfWork.EducationalQualification.AddAsync(qualification);
            return result;
        }

        [HttpGet("GetAllEducationalQualifications")]
        public async Task<ActionResult<List<EducationalQualification>>> GetAllEducationalQualifications()
        {
            var result = await _unitOfWork.EducationalQualification.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEducationalQualification")]
        public async Task<ActionResult<EducationalQualification>> EditEducationalQualification(EducationalQualification qualification)
        {
            var result = _unitOfWork.EducationalQualification.Update(qualification);
            await _unitOfWork.Save();
            return result;
        }
        [HttpGet("GetEditEducationalQualificationById")]
        public async Task<ActionResult<EducationalQualification>> GetEditEducationalQualificationById(int id)
        {
            try
            {
                var result = _unitOfWork.EducationalQualification.GetById(id);
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
            var result = await _unitOfWork.PreviousWorkExperience.AddAsync(experience);
            return result;
        }

        [HttpGet("GetAllPreviousWorkExperiences")]
        public async Task<ActionResult<List<PreviousWorkExperience>>> GetAllPreviousWorkExperiences()
        {
            var result = await _unitOfWork.PreviousWorkExperience.GetAll();
            return Ok(result);
        }
        [HttpGet("GetPreviousWorkExperienceById")]
        public async Task<ActionResult<PreviousWorkExperience>> GetPreviousWorkExperienceById(int id)
        {
            try
            {
                var result = _unitOfWork.PreviousWorkExperience.GetById(id);
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
            var result = _unitOfWork.PreviousWorkExperience.Update(experience);
            await _unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateEmployeeAttendance")]
        public async Task<ActionResult<EmployeeAttendanceLeaves>> CreateEmployeeAttendance(EmployeeAttendanceLeaves attendanceLeaves)
        {
            var result = await _unitOfWork.EmployeeAttendance.AddAsync(attendanceLeaves);
            return result;
        }
        [HttpGet("GetEmployeeAttendanceById")]
        public async Task<ActionResult<EmployeeAttendanceLeaves>> GetEmployeeAttendanceById(int id)
        {
            try
            {
                var result = _unitOfWork.EmployeeAttendance.GetById(id);
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
            var result = await _unitOfWork.EmployeeAttendance.GetAll();
            return Ok(result);
        }
        [HttpPost("EditEmployeeAttendance")]
        public async Task<ActionResult<EmployeeAttendanceLeaves>> EditEmployeeAttendance(EmployeeAttendanceLeaves attendanceLeaves)
        {
            var result = _unitOfWork.EmployeeAttendance.Update(attendanceLeaves);
            await _unitOfWork.Save();
            return result;
        }
    }
}
