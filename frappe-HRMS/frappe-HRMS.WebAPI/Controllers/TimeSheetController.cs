using frappe_HRMS.Domain.TimeSheets;
using frappe_HRMS.Services.Interfaces.TimeSheet;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSheetController(ITimeSheetService timeSheetService,ITimeSheetListService timeSheetListService,
        IBillingDetailsService billingDetailsService, IActivityTypeService activityTypeService) : ControllerBase
    {
        [HttpPost("CreateTimeSheet")]
        public async Task<ActionResult<TimeSheet>> CreateTimeSheet(TimeSheet timeSheet)
        {
            var result = await timeSheetService.AddAsync(timeSheet);
            return result;
        }

        [HttpGet("GetAllTimeSheets")]
        public async Task<ActionResult<List<TimeSheet>>> GetAllTimeSheets()
        {
            var result = await timeSheetService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetTimeSheetById")]
        public async Task<ActionResult<TimeSheet>> GetTimeSheetById(int id)
        {
            try
            {
                var result = timeSheetService.GetById(id);
                if (result == null)
                {
                    return NotFound($"TimeSheet with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditTimeSheet")]
        public async Task<ActionResult<TimeSheet>> EditTimeSheet(TimeSheet timeSheet)
        {
            var result = await timeSheetService.Update(timeSheet);
            return result;
        }
        [HttpPost("CreateTimeSheetList")]
        public async Task<ActionResult<TimeSheetList>> CreateTimeSheetList(TimeSheetList timeSheetList)
        {
            var result = await timeSheetListService.AddAsync(timeSheetList);
            return result;
        }

        [HttpGet("GetAllTimeSheetLists")]
        public async Task<ActionResult<List<TimeSheetList>>> GetAllTimeSheetLists()
        {
            var result = await timeSheetListService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetTimeSheetListById")]
        public async Task<ActionResult<TimeSheetList>> GetTimeSheetListById(int id)
        {
            try
            {
                var result = timeSheetListService.GetById(id);
                if (result == null)
                {
                    return NotFound($"TimeSheetList with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditTimeSheetList")]
        public async Task<ActionResult<TimeSheetList>> EditTimeSheetList(TimeSheetList timeSheetList)
        {
            var result = await timeSheetListService.Update(timeSheetList);
            return result;
        }
        [HttpPost("CreateActivityType")]
        public async Task<ActionResult<ActivityType>> CreateActivityType(ActivityType type)
        {
            var result = await activityTypeService.AddAsync(type);
            return result;
        }

        [HttpGet("GetAllActivityTypes")]
        public async Task<ActionResult<List<ActivityType>>> GetAllActivityTypes()
        {
            var result = await activityTypeService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetActivityTypeById")]
        public async Task<ActionResult<ActivityType>> GetActivityTypeById(int id)
        {
            try
            {
                var result = activityTypeService.GetById(id);
                if (result == null)
                {
                    return NotFound($"ActivityType with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditActivityType")]
        public async Task<ActionResult<ActivityType>> EditActivityType(ActivityType type)
        {
            var result = await activityTypeService.Update(type);
            return result;
        }
        [HttpPost("CreateBillingDetails")]
        public async Task<ActionResult<BillingDetails>> CreateBillingDetails(BillingDetails billingDetails)
        {
            var result = await billingDetailsService.AddAsync(billingDetails);
            return result;
        }

        [HttpGet("GetAllBillingDetails")]
        public async Task<ActionResult<List<BillingDetails>>> GetAllBillingDetails()
        {
            var result = await billingDetailsService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetBillingDetailsById")]
        public async Task<ActionResult<BillingDetails>> GetBillingDetailsById(int id)
        {
            try
            {
                var result = billingDetailsService.GetById(id);
                if (result == null)
                {
                    return NotFound($"BillingDetails with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditBillingDetails")]
        public async Task<ActionResult<BillingDetails>> EditBillingDetails(BillingDetails billingDetails)
        {
            var result = await billingDetailsService.Update(billingDetails);
            return result;
        }
    }
}
