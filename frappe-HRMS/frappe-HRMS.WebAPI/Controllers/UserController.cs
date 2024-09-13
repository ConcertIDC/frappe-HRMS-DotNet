using frappe_HRMS.Domain;
using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            var result = await _unitOfWork.Signup.AddAsync(user);
            return result;
        }

        [HttpGet("GetAllUsers")]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var result = await _unitOfWork.Signup.GetAll();
            return Ok(result);
        }
        [HttpPost("EditUser")]
        public async Task<ActionResult<User>> EditUser(User user)
        {
            var result = _unitOfWork.Signup.Update(user);
            await _unitOfWork.Save();
            return result;
        }
    }
}
