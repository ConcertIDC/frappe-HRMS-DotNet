using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Domain.Leave;
using frappe_HRMS.Services.Interfaces;
using frappe_HRMS.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpPost("CreateLeaveApplication")]
        public async Task<ActionResult<LeaveApplication>> CreateLeaveApplication(LeaveApplication leave)
        {
            var result = await unitOfWork.LeaveApplication.AddAsync(leave);
            return result;
        }

        [HttpGet("GetAllLeaveApplications")]
        public async Task<ActionResult<List<LeaveApplication>>> GetAllLeaveApplications()
        {
            var result = await unitOfWork.LeaveApplication.GetAll();
            return Ok(result);
        }
        [HttpGet("GetLeaveApplicationById")]
        public async Task<ActionResult<LeaveApplication>> GetLeaveApplicationById(int id)
        {
            try
            {
                var result = unitOfWork.LeaveApplication.GetById(id);
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
            var result = unitOfWork.LeaveApplication.Update(leave);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateLeaveType")]
        public async Task<ActionResult<LeaveType>> CreateLeaveType(LeaveType leaveType)
        {
            var result = await unitOfWork.LeaveType.AddAsync(leaveType);
            return result;
        }

        [HttpGet("GetAllLeaveTypes")]
        public async Task<ActionResult<List<LeaveType>>> GetAllLeaveTypes()
        {
            var result = await unitOfWork.LeaveType.GetAll();
            return Ok(result);
        }
        [HttpGet("GetLeaveTypeById")]
        public async Task<ActionResult<LeaveType>> GetLeaveTypeById(int id)
        {
            try
            {
                var result = unitOfWork.LeaveType.GetById(id);
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
            var result = unitOfWork.LeaveType.Update(leaveType);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateCompensatoryLeaveRequest")]
        public async Task<ActionResult<CompensatoryLeaveRequest>> CreateCompensatoryLeaveRequest(CompensatoryLeaveRequest compensatoryLeave)
        {
            var result = await unitOfWork.CompensatoryLeaveRequest.AddAsync(compensatoryLeave);
            return result;
        }

        [HttpGet("GetAllCompensatoryLeaveRequests")]
        public async Task<ActionResult<List<CompensatoryLeaveRequest>>> GetAllCompensatoryLeaveRequests()
        {
            var result = await unitOfWork.CompensatoryLeaveRequest.GetAll();
            return Ok(result);
        }
        [HttpGet("GetCompensatoryLeaveRequestId")]
        public async Task<ActionResult<CompensatoryLeaveRequest>> GetCompensatoryLeaveRequestById(int id)
        {
            try
            {
                var result = unitOfWork.CompensatoryLeaveRequest.GetById(id);
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
            var result = unitOfWork.CompensatoryLeaveRequest.Update(compensatoryLeave);
            await unitOfWork.Save();
            return result;
        }
    }
}
