using frappe_HRMS.Domain;
using frappe_HRMS.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupController(ISignupService signupService) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<User>> Create([FromBody] User request)
        {
            var result =  await signupService.AddAsync(request);
            return Ok(result);
        }

    }
}
