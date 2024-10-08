using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Services.Interfaces;
using frappe_HRMS.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpPost("CreateAttendance")]
        public async Task<ActionResult<Attendance>> CreateAttendance(Attendance attendance)
        {
            var result = await unitOfWork.Attendance.AddAsync(attendance);
            return result;
        }

        [HttpGet("GetAllAttendances")]
        public async Task<ActionResult<List<Attendance>>> GetAllAttendances()
        {
            var result = await unitOfWork.Attendance.GetAll();
            return Ok(result);
        }
        [HttpGet("GetAttendanceById")]
        public async Task<ActionResult<Attendance>> GetAttendanceById(int id)
        {
            try
            {
                var result = unitOfWork.Attendance.GetById(id);
                if (result == null)
                {
                    return NotFound($"Attendance with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditAttendance")]
        public async Task<ActionResult<Attendance>> EditEmployee(Attendance attendance)
        {
            var result = unitOfWork.Attendance.Update(attendance);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateAttendanceRequest")]
        public async Task<ActionResult<AttendanceRequest>> CreateAttendanceRequest(AttendanceRequest attendance)
        {
            var result = await unitOfWork.AttendanceRequest.AddAsync(attendance);
            return result;
        }

        [HttpGet("GetAllAttendanceRequests")]
        public async Task<ActionResult<List<AttendanceRequest>>> GetAllAttendanceRequests()
        {
            var result = await unitOfWork.AttendanceRequest.GetAll();
            return Ok(result);
        }
        [HttpGet("GetAttendanceRequestById")]
        public async Task<ActionResult<AttendanceRequest>> GetAttendanceRequestById(int id)
        {
            try
            {
                var result = unitOfWork.AttendanceRequest.GetById(id);
                if (result == null)
                {
                    return NotFound($"Attendance with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AttendanceRequest")]
        public async Task<ActionResult<AttendanceRequest>> EditEmployee(AttendanceRequest attendance)
        {
            var result = unitOfWork.AttendanceRequest.Update(attendance);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateShiftType")]
        public async Task<ActionResult<ShiftType>> CreateAttendance(ShiftType shift)
        {
            var result = await unitOfWork.ShiftType.AddAsync(shift);
            return result;
        }

        [HttpGet("GetAllShiftTypes")]
        public async Task<ActionResult<List<ShiftType>>> GetAllShiftTypes()
        {
            var result = await unitOfWork.ShiftType.GetAll();
            return Ok(result);
        }
        [HttpGet("GetShiftTypeById")]
        public async Task<ActionResult<ShiftType>> GetShiftTypeById(int id)
        {
            try
            {
                var result = unitOfWork.ShiftType.GetById(id);
                if (result == null)
                {
                    return NotFound($"ShiftType with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditShiftType")]
        public async Task<ActionResult<ShiftType>> EditEmployee(ShiftType shift)
        {
            var result = unitOfWork.ShiftType.Update(shift);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateEmployeeCheckin")]
        public async Task<ActionResult<EmployeeCheckin>> CreateEmployeeCheckin(EmployeeCheckin checkin)
        {
            var result = await unitOfWork.EmployeeCheckin.AddAsync(checkin);
            return result;
        }

        [HttpGet("GetAllEmployeeCheckins")]
        public async Task<ActionResult<List<EmployeeCheckin>>> GetAllEmployeeCheckins()
        {
            var result = await unitOfWork.EmployeeCheckin.GetAll();
            return Ok(result);
        }
        [HttpGet("GetEmployeeCheckinById")]
        public async Task<ActionResult<EmployeeCheckin>> GetEmployeeCheckinById(int id)
        {
            try
            {
                var result = unitOfWork.EmployeeCheckin.GetById(id);
                if (result == null)
                {
                    return NotFound($"EmployeeCheckin with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditEmployeeCheckin")]
        public async Task<ActionResult<EmployeeCheckin>> EditEmployeeCheckin(EmployeeCheckin checkin)
        {
            var result = unitOfWork.EmployeeCheckin.Update(checkin);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateHolidayList")]
        public async Task<ActionResult<HolidayList>> CreateHolidayList(HolidayList holidayList)
        {
            var result = await unitOfWork.HolidayList.AddAsync(holidayList);
            return result;
        }

        [HttpGet("GetAllHolidayLists")]
        public async Task<ActionResult<List<HolidayList>>> GetAllHolidayLists()
        {
            var result = await unitOfWork.HolidayList.GetAll();
            return Ok(result);
        }
        [HttpGet("GetHolidayListById")]
        public async Task<ActionResult<HolidayList>> GetHolidayListById(int id)
        {
            try
            {
                var result = unitOfWork.HolidayList.GetById(id);
                if (result == null)
                {
                    return NotFound($"HolidayList with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditHolidayList")]
        public async Task<ActionResult<HolidayList>> EditHolidayList(HolidayList holidayList)
        {
            var result = unitOfWork.HolidayList.Update(holidayList);
            await unitOfWork.Save();
            return result;
        }
    }
}
