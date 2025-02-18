using frappe_HRMS.Domain.Leave;
using frappe_HRMS.Services.Interfaces.Leave;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveController(ILeaveApplicationService leaveApplicationService,ILeaveTypeService leaveTypeService,
        ICompensatoryLeaveRequestService compensatoryLeaveRequestService) : ControllerBase
    {
        [HttpPost("CreateLeaveApplication")]
        public async Task<ActionResult<LeaveApplication>> CreateLeaveApplication(LeaveApplication leave)
        {
            var result = await leaveApplicationService.AddAsync(leave);
            return result;
        }

        [HttpGet("GetAllLeaveApplications")]
        public async Task<ActionResult<List<LeaveApplication>>> GetAllLeaveApplications()
        {
            var result = await leaveApplicationService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetLeaveApplicationById")]
        public async Task<ActionResult<LeaveApplication>> GetLeaveApplicationById(int id)
        {
            try
            {
                var result = leaveApplicationService.GetById(id);
                if (result == null)
                {
                    return NotFound($"LeaveApplication with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditLeaveApplication")]
        public async Task<ActionResult<LeaveApplication>> EditLeaveApplication(LeaveApplication leave)
        {
            var result = await leaveApplicationService.Update(leave);
            return result;
        }
        [HttpPost("CreateLeaveType")]
        public async Task<ActionResult<LeaveType>> CreateLeaveType(LeaveType leaveType)
        {
            var result = await leaveTypeService.AddAsync(leaveType);
            return result;
        }

        [HttpGet("GetAllLeaveTypes")]
        public async Task<ActionResult<List<LeaveType>>> GetAllLeaveTypes()
        {
            var result = await leaveTypeService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetLeaveTypeById")]
        public async Task<ActionResult<LeaveType>> GetLeaveTypeById(int id)
        {
            try
            {
                var result = leaveTypeService.GetById(id);
                if (result == null)
                {
                    return NotFound($"LeaveType with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditLeaveType")]
        public async Task<ActionResult<LeaveType>> EditLeaveType(LeaveType leaveType)
        {
            var result = await leaveTypeService.Update(leaveType);
            return result;
        }
        [HttpPost("CreateCompensatoryLeaveRequest")]
        public async Task<ActionResult<CompensatoryLeaveRequest>> CreateCompensatoryLeaveRequest(CompensatoryLeaveRequest compensatoryLeave)
        {
            var result = await compensatoryLeaveRequestService.AddAsync(compensatoryLeave);
            return result;
        }

        [HttpGet("GetAllCompensatoryLeaveRequests")]
        public async Task<ActionResult<List<CompensatoryLeaveRequest>>> GetAllCompensatoryLeaveRequests()
        {
            var result = await compensatoryLeaveRequestService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetCompensatoryLeaveRequestId")]
        public async Task<ActionResult<CompensatoryLeaveRequest>> GetCompensatoryLeaveRequestById(int id)
        {
            try
            {
                var result = compensatoryLeaveRequestService.GetById(id);
                if (result == null)
                {
                    return NotFound($"LeaveType with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditCompensatoryLeaveRequest")]
        public async Task<ActionResult<CompensatoryLeaveRequest>> EditCompensatoryLeaveRequest(CompensatoryLeaveRequest compensatoryLeave)
        {
            var result = await compensatoryLeaveRequestService.Update(compensatoryLeave);
            return result;
        }
    }
}
