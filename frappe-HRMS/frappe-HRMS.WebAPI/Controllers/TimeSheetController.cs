using frappe_HRMS.Domain.TimeSheets;
using frappe_HRMS.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSheetController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpPost("CreateTimeSheet")]
        public async Task<ActionResult<TimeSheet>> CreateTimeSheet(TimeSheet timeSheet)
        {
            var result = await unitOfWork.TimeSheet.AddAsync(timeSheet);
            return result;
        }

        [HttpGet("GetAllTimeSheets")]
        public async Task<ActionResult<List<TimeSheet>>> GetAllTimeSheets()
        {
            var result = await unitOfWork.TimeSheet.GetAll();
            return Ok(result);
        }
        [HttpGet("GetTimeSheetById")]
        public async Task<ActionResult<TimeSheet>> GetTimeSheetById(int id)
        {
            try
            {
                var result = unitOfWork.TimeSheet.GetById(id);
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
            var result = unitOfWork.TimeSheet.Update(timeSheet);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateTimeSheetList")]
        public async Task<ActionResult<TimeSheetList>> CreateTimeSheetList(TimeSheetList timeSheetList)
        {
            var result = await unitOfWork.TimeSheetList.AddAsync(timeSheetList);
            return result;
        }

        [HttpGet("GetAllTimeSheetLists")]
        public async Task<ActionResult<List<TimeSheetList>>> GetAllTimeSheetLists()
        {
            var result = await unitOfWork.TimeSheetList.GetAll();
            return Ok(result);
        }
        [HttpGet("GetTimeSheetListById")]
        public async Task<ActionResult<TimeSheetList>> GetTimeSheetListById(int id)
        {
            try
            {
                var result = unitOfWork.TimeSheetList.GetById(id);
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
            var result = unitOfWork.TimeSheetList.Update(timeSheetList);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateActivityType")]
        public async Task<ActionResult<ActivityType>> CreateActivityType(ActivityType type)
        {
            var result = await unitOfWork.ActivityType.AddAsync(type);
            return result;
        }

        [HttpGet("GetAllActivityTypes")]
        public async Task<ActionResult<List<ActivityType>>> GetAllActivityTypes()
        {
            var result = await unitOfWork.ActivityType.GetAll();
            return Ok(result);
        }
        [HttpGet("GetActivityTypeById")]
        public async Task<ActionResult<ActivityType>> GetActivityTypeById(int id)
        {
            try
            {
                var result = unitOfWork.ActivityType.GetById(id);
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
            var result = unitOfWork.ActivityType.Update(type);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateBillingDetails")]
        public async Task<ActionResult<BillingDetails>> CreateBillingDetails(BillingDetails billingDetails)
        {
            var result = await unitOfWork.BillingDetails.AddAsync(billingDetails);
            return result;
        }

        [HttpGet("GetAllBillingDetails")]
        public async Task<ActionResult<List<BillingDetails>>> GetAllBillingDetails()
        {
            var result = await unitOfWork.BillingDetails.GetAll();
            return Ok(result);
        }
        [HttpGet("GetBillingDetailsById")]
        public async Task<ActionResult<BillingDetails>> GetBillingDetailsById(int id)
        {
            try
            {
                var result = unitOfWork.BillingDetails.GetById(id);
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
            var result = unitOfWork.BillingDetails.Update(billingDetails);
            await unitOfWork.Save();
            return result;
        }
    }
}
