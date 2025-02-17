using frappe_HRMS.Domain;
using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(ISignupService signupService) : ControllerBase
    {
        [HttpPost("CreateUser")]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            var result = await signupService.AddAsync(user);
            return result;
        }

        [HttpGet("GetAllUsers")]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var result = await signupService.GetAll();
            return Ok(result);
        }
        [HttpPost("EditUser")]
        public async Task<ActionResult<User>> EditUser(User user)
        {
            var result = await signupService.Update(user);
            return result;
        }
    }
}
