using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Services.Interfaces;
using frappe_HRMS.Services.Interfaces.Attendance;
using frappe_HRMS.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController(IAttendanceService attendanceService, IAttendanceRequestService attendanceRequestService,
        IShiftTypeService shiftTypeService,IEmployeeCheckinService employeeCheckinService,IHolidayListService holidayListService) : ControllerBase
    {
        [HttpPost("CreateAttendance")]
        public async Task<ActionResult<Attendance>> CreateAttendance(Attendance attendance)
        {
            var result = await attendanceService.AddAsync(attendance);
            return result;
        }

        [HttpGet("GetAllAttendances")]
        public async Task<ActionResult<List<Attendance>>> GetAllAttendances()
        {
            var result = await attendanceService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetAttendanceById")]
        public async Task<ActionResult<Attendance>> GetAttendanceById(int id)
        {
            try
            {
                var result = attendanceService.GetById(id);
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
        public async Task<ActionResult<Attendance>> EditAttendance(Attendance attendance)
        {
            var result = await attendanceService.Update(attendance);
            return result;
        }
        [HttpPost("CreateAttendanceRequest")]
        public async Task<ActionResult<AttendanceRequest>> CreateAttendanceRequest(AttendanceRequest attendance)
        {
            var result = await attendanceRequestService.AddAsync(attendance);
            return result;
        }

        [HttpGet("GetAllAttendanceRequests")]
        public async Task<ActionResult<List<AttendanceRequest>>> GetAllAttendanceRequests()
        {
            var result = await attendanceRequestService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetAttendanceRequestById")]
        public async Task<ActionResult<AttendanceRequest>> GetAttendanceRequestById(int id)
        {
            try
            {
                var result = attendanceRequestService.GetById(id);
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
        public async Task<ActionResult<AttendanceRequest>> EditAttendanceRequest(AttendanceRequest attendance)
        {
            var result = await attendanceRequestService.Update(attendance);
            return result;
        }
        [HttpPost("CreateShiftType")]
        public async Task<ActionResult<ShiftType>> CreateAttendance(ShiftType shift)
        {
            var result = await shiftTypeService.AddAsync(shift);
            return result;
        }

        [HttpGet("GetAllShiftTypes")]
        public async Task<ActionResult<List<ShiftType>>> GetAllShiftTypes()
        {
            var result = await shiftTypeService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetShiftTypeById")]
        public async Task<ActionResult<ShiftType>> GetShiftTypeById(int id)
        {
            try
            {
                var result = shiftTypeService.GetById(id);
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
            var result = await shiftTypeService.Update(shift);
            return result;
        }
        [HttpPost("CreateEmployeeCheckin")]
        public async Task<ActionResult<EmployeeCheckin>> CreateEmployeeCheckin(EmployeeCheckin checkin)
        {
            var result = await employeeCheckinService.AddAsync(checkin);
            return result;
        }

        [HttpGet("GetAllEmployeeCheckins")]
        public async Task<ActionResult<List<EmployeeCheckin>>> GetAllEmployeeCheckins()
        {
            var result = await employeeCheckinService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetEmployeeCheckinById")]
        public async Task<ActionResult<EmployeeCheckin>> GetEmployeeCheckinById(int id)
        {
            try
            {
                var result = employeeCheckinService.GetById(id);
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
            var result = await employeeCheckinService.Update(checkin);
            return result;
        }
        [HttpPost("CreateHolidayList")]
        public async Task<ActionResult<HolidayList>> CreateHolidayList(HolidayList holidayList)
        {
            var result = await holidayListService.AddAsync(holidayList);
            return result;
        }

        [HttpGet("GetAllHolidayLists")]
        public async Task<ActionResult<List<HolidayList>>> GetAllHolidayLists()
        {
            var result = await holidayListService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetHolidayListById")]
        public async Task<ActionResult<HolidayList>> GetHolidayListById(int id)
        {
            try
            {
                var result = holidayListService.GetById(id);
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
            var result = await holidayListService.Update(holidayList);
            return result;
        }
    }
}
