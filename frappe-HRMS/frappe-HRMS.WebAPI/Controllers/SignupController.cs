using Azure;
using Azure.Core;
using frappe_HRMS.Domain;
using frappe_HRMS.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<User>> Create([FromBody] User request)
        {
            var result =  await unitOfWork.Signup.AddAsync(request);
            await unitOfWork.Save();
            return Ok(result);
        }

    }
}
