using frappe_HRMS.Domain.Company;
using frappe_HRMS.Services.Interfaces.Company;
using frappe_HRMS.Services.Services.Company;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController(IBranchService branchService,ICompanyService companyService,
        IDepartmentService departmentService,IDesignationService designationService, IEmploymentTypeService employmentTypeService) : ControllerBase
    {
        [HttpPost("SetupOrganisation")]
        public async Task<ActionResult<Company>> SetupOrganisation(Company company)
        {
            var result = await companyService.SetupOrganisation(company);
            return Ok(result);
        }

        [HttpPost("CreateCompany")]
        public async Task<ActionResult<Company>> CreateCompany(Company company)
        {
            var result = await companyService.AddAsync(company);
            return Ok(result);
        }

        [HttpGet("GetAllCompanies")]
        public async Task<ActionResult<List<Company>>> GetAllCompanies()
        {
            var result = await companyService.GetAllCompanies();
            return Ok(result);
        }

        [HttpPost("EditCompany")]
        public async Task<ActionResult<Company>> EditCompany(Company company)
        {
            var result = await companyService.Update(company);
            return result;
        }
        [HttpPost("CreateBranch")]
        public async Task<ActionResult<Branch>> CreateBranch(Branch branch)
        {
            var result = await branchService.AddAsync(branch);
            return result;
        }

        [HttpGet("GetAllBranches")]
        public async Task<ActionResult<List<Branch>>> GetAllBranches()
        {
            var result = await branchService.GetAll();
            return Ok(result);
        }

        [HttpPost("EditBranch")]
        public async Task<ActionResult<Branch>> EditBranch(Branch branch)
        {
            var result = await branchService.Update(branch);
            return result;
        }
        [HttpPost("CreateDepartment")]
        public async Task<ActionResult<Department>> CreateDepartment(Department department)
        {
            var result = await departmentService.AddAsync(department);
            return result;
        }

        [HttpGet("GetAllDepartments")]
        public async Task<ActionResult<List<Department>>> GetAllDepartments()
        {
            var result = await departmentService.GetAll();
            return Ok(result);
        }

        [HttpPost("EditDepartment")]
        public async Task<ActionResult<Department>> EditDepartment(Department department)
        {
            var result = await departmentService.Update(department);
            return result;
        }
        [HttpPost("CreateDesignation")]
        public async Task<ActionResult<Designation>> CreateDesination(Designation designation)
        {
            var result = await designationService.AddAsync(designation);
            return result;
        }

        [HttpGet("GetAllDesignations")]
        public async Task<ActionResult<List<Designation>>> GetAllDesignations()
        {
            var result = await designationService.GetAll();
            return Ok(result);
        }

        [HttpPost("EditDesignation")]
        public async Task<ActionResult<Designation>> EditDesignation(Designation designation)
        {
            var result = await designationService.Update(designation);
            return result;
        }
        [HttpGet("GetCompanyList")]
        public ActionResult<List<Company>> GetCompanyList()
        {
            var result = companyService.GetCompanyList();
            return Ok(result);
        }
        [HttpPost("CreateEmploymentType")]
        public async Task<ActionResult<EmploymentType>> CreateEmploymentType(EmploymentType employmentType)
        {
            var result = await employmentTypeService.AddAsync(employmentType);
            return result;
        }

        [HttpGet("GetAllemploymentTypes")]
        public async Task<ActionResult<List<EmploymentType>>> GetAllemploymentTypes()
        {
            var result = await employmentTypeService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetEmploymentTypeById")]
        public async Task<ActionResult<EmploymentType>> GetEmploymentTypeById(int id)
        {
            try
            {
                var result = employmentTypeService.GetById(id);
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
            var result = await employmentTypeService.Update(employmentType);
            return result;
        }
    }
}
