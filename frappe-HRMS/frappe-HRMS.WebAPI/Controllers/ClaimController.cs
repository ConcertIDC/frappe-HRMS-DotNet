using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpPost("CreateExpenseClaim")]
        public async Task<ActionResult<ExpenseClaim>> CreateExpenseClaim(ExpenseClaim expenseClaim)
        {
            var result = await unitOfWork.ExpenseClaim.AddAsync(expenseClaim);
            return result;
        }

        [HttpGet("GetAllExpenseClaims")]
        public async Task<ActionResult<List<ExpenseClaim>>> GetAllExpenseClaims()
        {
            var result = await unitOfWork.ExpenseClaim.GetAll();
            return Ok(result);
        }
        [HttpGet("GetExpenseClaimById")]
        public async Task<ActionResult<ExpenseClaim>> GetExpenseClaimById(int id)
        {
            try
            {
                var result = unitOfWork.ExpenseClaim.GetById(id);
                if (result == null)
                {
                    return NotFound($"ExpenseClaim with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditExpenseClaim")]
        public async Task<ActionResult<ExpenseClaim>> EditExpenseClaim(ExpenseClaim expenseClaim)
        {
            var result = unitOfWork.ExpenseClaim.Update(expenseClaim);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateExpenseClaimType")]
        public async Task<ActionResult<ExpenseClaimType>> CreateExpenseClaimType(ExpenseClaimType expenseClaimType)
        {
            var result = await unitOfWork.ExpenseClaimType.AddAsync(expenseClaimType);
            return result;
        }

        [HttpGet("GetAllExpenseClaimTypes")]
        public async Task<ActionResult<List<ExpenseClaimType>>> GetAllExpenseClaimTypes()
        {
            var result = await unitOfWork.ExpenseClaimType.GetAll();
            return Ok(result);
        }
        [HttpGet("GetExpenseClaimTypeById")]
        public async Task<ActionResult<ExpenseClaimType>> GetExpenseClaimTypeById(int id)
        {
            try
            {
                var result = unitOfWork.ExpenseClaimType.GetById(id);
                if (result == null)
                {
                    return NotFound($"ExpenseClaim Type with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditExpenseClaimType")]
        public async Task<ActionResult<ExpenseClaimType>> EditExpenseClaimType(ExpenseClaimType expenseClaimType)
        {
            var result = unitOfWork.ExpenseClaimType.Update(expenseClaimType);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateExpenses")]
        public async Task<ActionResult<Expenses>> CreateExpenses(Expenses expenses)
        {
            var result = await unitOfWork.Expenses.AddAsync(expenses);
            return result;
        }

        [HttpGet("GetAllExpenses")]
        public async Task<ActionResult<List<Expenses>>> GetAllExpenses()
        {
            var result = await unitOfWork.Expenses.GetAll();
            return Ok(result);
        }
        [HttpGet("GetExpensesById")]
        public async Task<ActionResult<Expenses>> GetExpensesById(int id)
        {
            try
            {
                var result = unitOfWork.Expenses.GetById(id);
                if (result == null)
                {
                    return NotFound($"Expenses with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditExpenses")]
        public async Task<ActionResult<Expenses>> EditExpenses(Expenses expenses)
        {
            var result = unitOfWork.Expenses.Update(expenses);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateTravelRequest")]
        public async Task<ActionResult<TravelRequest>> CreateTravelRequest(TravelRequest travelRequest)
        {
            var result = await unitOfWork.TravelRequest.AddAsync(travelRequest);
            return result;
        }

        [HttpGet("GetAllTravelRequests")]
        public async Task<ActionResult<List<TravelRequest>>> GetAllTravelRequests()
        {
            var result = await unitOfWork.TravelRequest.GetAll();
            return Ok(result);
        }
        [HttpGet("GetTravelRequestById")]
        public async Task<ActionResult<TravelRequest>> GetTravelRequestById(int id)
        {
            try
            {
                var result = unitOfWork.TravelRequest.GetById(id);
                if (result == null)
                {
                    return NotFound($"TravelRequest with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditTravelRequests")]
        public async Task<ActionResult<TravelRequest>> EditTravelRequest(TravelRequest travelRequest)
        {
            var result = unitOfWork.TravelRequest.Update(travelRequest);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateTravelItinerary")]
        public async Task<ActionResult<TravelItinerary>> CreateTravelItinerary(TravelItinerary travelItinerary)
        {
            var result = await unitOfWork.TravelItinerary.AddAsync(travelItinerary);
            return result;
        }

        [HttpGet("GetAllTravelItineraries")]
        public async Task<ActionResult<List<TravelItinerary>>> GetAllTravelItineraries()
        {
            var result = await unitOfWork.TravelItinerary.GetAll();
            return Ok(result);
        }
        [HttpGet("GetTravelItineraryById")]
        public async Task<ActionResult<TravelItinerary>> GetTravelItineraryById(int id)
        {
            try
            {
                var result = unitOfWork.TravelItinerary.GetById(id);
                if (result == null)
                {
                    return NotFound($"TravelItinerary with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditTravelItinerary")]
        public async Task<ActionResult<TravelItinerary>> EditTravelItinerary(TravelItinerary travelItinerary)
        {
            var result = unitOfWork.TravelItinerary.Update(travelItinerary);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreatePurposeOfTravel")]
        public async Task<ActionResult<PurposeOfTravel>> CreatePurposeOfTravel(PurposeOfTravel purpose)
        {
            var result = await unitOfWork.PurposeOfTravel.AddAsync(purpose);
            return result;
        }

        [HttpGet("GetAllPurposeOfTravels")]
        public async Task<ActionResult<List<PurposeOfTravel>>> GetAllPurposeOfTravels()
        {
            var result = await unitOfWork.PurposeOfTravel.GetAll();
            return Ok(result);
        }
        [HttpGet("GetPurposeOfTravelById")]
        public async Task<ActionResult<PurposeOfTravel>> GetPurposeOfTravelById(int id)
        {
            try
            {
                var result = unitOfWork.PurposeOfTravel.GetById(id);
                if (result == null)
                {
                    return NotFound($"PurposeOfTravel with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditPurposeOfTravel")]
        public async Task<ActionResult<PurposeOfTravel>> EditPurposeOfTravel(PurposeOfTravel purpose)
        {
            var result = unitOfWork.PurposeOfTravel.Update(purpose);
            await unitOfWork.Save();
            return result;
        }
    }
}
