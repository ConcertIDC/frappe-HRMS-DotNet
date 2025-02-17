using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Services.Interfaces.Claim;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController(IExpensesService expensesService,IExpenseClaimService expenseClaimService,
        IExpenseClaimTypeService expenseClaimTypeService,ITravelRequestService travelRequestService,ITravelItineraryService travelItineraryService,
        IPurposeOfTravelService purposeOfTravelService,IAccountService accountService,
        IAdvancePaymentService advancePaymentService,IModeOfPaymentService modeOfPaymentService,ITaxesAndChargesService taxesAndChargesService) : ControllerBase
    {
        [HttpPost("CreateExpenseClaim")]
        public async Task<ActionResult<ExpenseClaim>> CreateExpenseClaim(ExpenseClaim expenseClaim)
        {
            var result = await expenseClaimService.AddAsync(expenseClaim);
            return result;
        }

        [HttpGet("GetAllExpenseClaims")]
        public async Task<ActionResult<List<ExpenseClaim>>> GetAllExpenseClaims()
        {
            var result = await expenseClaimService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetExpenseClaimById")]
        public async Task<ActionResult<ExpenseClaim>> GetExpenseClaimById(int id)
        {
            try
            {
                var result = expenseClaimService.GetById(id);
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
            var result = await expenseClaimService.Update(expenseClaim);
            return result;
        }
        [HttpPost("CreateExpenseClaimType")]
        public async Task<ActionResult<ExpenseClaimType>> CreateExpenseClaimType(ExpenseClaimType expenseClaimType)
        {
            var result = await expenseClaimTypeService.AddAsync(expenseClaimType);
            return result;
        }

        [HttpGet("GetAllExpenseClaimTypes")]
        public async Task<ActionResult<List<ExpenseClaimType>>> GetAllExpenseClaimTypes()
        {
            var result = await expenseClaimTypeService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetExpenseClaimTypeById")]
        public async Task<ActionResult<ExpenseClaimType>> GetExpenseClaimTypeById(int id)
        {
            try
            {
                var result = expenseClaimTypeService.GetById(id);
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
            var result = await expenseClaimTypeService.Update(expenseClaimType);
            return result;
        }
        [HttpPost("CreateExpenses")]
        public async Task<ActionResult<Expenses>> CreateExpenses(Expenses expenses)
        {
            var result = await expensesService.AddAsync(expenses);
            return result;
        }

        [HttpGet("GetAllExpenses")]
        public async Task<ActionResult<List<Expenses>>> GetAllExpenses()
        {
            var result = await expensesService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetExpensesById")]
        public async Task<ActionResult<Expenses>> GetExpensesById(int id)
        {
            try
            {
                var result = expensesService.GetById(id);
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
            var result = await expensesService.Update(expenses);
            return result;
        }
        [HttpPost("CreateTravelRequest")]
        public async Task<ActionResult<TravelRequest>> CreateTravelRequest(TravelRequest travelRequest)
        {
            var result = await travelRequestService.AddAsync(travelRequest);
            return result;
        }

        [HttpGet("GetAllTravelRequests")]
        public async Task<ActionResult<List<TravelRequest>>> GetAllTravelRequests()
        {
            var result = await travelRequestService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetTravelRequestById")]
        public async Task<ActionResult<TravelRequest>> GetTravelRequestById(int id)
        {
            try
            {
                var result = travelRequestService.GetById(id);
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
            var result = await travelRequestService.Update(travelRequest);
            return result;
        }
        [HttpPost("CreateTravelItinerary")]
        public async Task<ActionResult<TravelItinerary>> CreateTravelItinerary(TravelItinerary travelItinerary)
        {
            var result = await travelItineraryService.AddAsync(travelItinerary);
            return result;
        }

        [HttpGet("GetAllTravelItineraries")]
        public async Task<ActionResult<List<TravelItinerary>>> GetAllTravelItineraries()
        {
            var result = await travelItineraryService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetTravelItineraryById")]
        public async Task<ActionResult<TravelItinerary>> GetTravelItineraryById(int id)
        {
            try
            {
                var result = travelItineraryService.GetById(id);
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
            var result = await travelItineraryService.Update(travelItinerary);
            return result;
        }
        [HttpPost("CreatePurposeOfTravel")]
        public async Task<ActionResult<PurposeOfTravel>> CreatePurposeOfTravel(PurposeOfTravel purpose)
        {
            var result = await purposeOfTravelService.AddAsync(purpose);
            return result;
        }

        [HttpGet("GetAllPurposeOfTravels")]
        public async Task<ActionResult<List<PurposeOfTravel>>> GetAllPurposeOfTravels()
        {
            var result = await purposeOfTravelService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetPurposeOfTravelById")]
        public async Task<ActionResult<PurposeOfTravel>> GetPurposeOfTravelById(int id)
        {
            try
            {
                var result = purposeOfTravelService.GetById(id);
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
            var result = await purposeOfTravelService.Update(purpose);
            return result;
        }
        [HttpPost("CreateAccount")]
        public async Task<ActionResult<Account>> CreateAccount(Account account)
        {
            var result = await accountService.AddAsync(account);
            return result;
        }

        [HttpGet("GetAllAccounts")]
        public async Task<ActionResult<List<Account>>> GetAllAccounts()
        {
            var result = await accountService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetAccountById")]
        public async Task<ActionResult<Account>> GetAccountById(int id)
        {
            try
            {
                var result = accountService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Account with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditAccount")]
        public async Task<ActionResult<Account>> EditAccount(Account account)
        {
            var result = await accountService.Update(account);
            return result;
        }
        [HttpPost("CreateAdvancePayments")]
        public async Task<ActionResult<AdvancePayments>> CreateAdvancePayments(AdvancePayments advancePayments)
        {
            var result = await advancePaymentService.AddAsync(advancePayments);
            return result;
        }

        [HttpGet("GetAllAdvancePayments")]
        public async Task<ActionResult<List<AdvancePayments>>> GetAllAdvancePayments()
        {
            var result = await advancePaymentService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetAdvancePaymentsById")]
        public async Task<ActionResult<AdvancePayments>> GetAdvancePaymentsById(int id)
        {
            try
            {
                var result = advancePaymentService.GetById(id);
                if (result == null)
                {
                    return NotFound($"AdvancePayments with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditAdvancePayments")]
        public async Task<ActionResult<AdvancePayments>> EditAdvancePayments(AdvancePayments advancePayments)
        {
            var result = await advancePaymentService.Update(advancePayments);
            return result;
        }
        [HttpPost("CreateModeOfPayment")]
        public async Task<ActionResult<ModeOfPayment>> CreateModeOfPayment(ModeOfPayment modeOfPayment)
        {
            var result = await modeOfPaymentService.AddAsync(modeOfPayment);
            return result;
        }

        [HttpGet("GetAllModeOfPayments")]
        public async Task<ActionResult<List<ModeOfPayment>>> GetAllModeOfPayments()
        {
            var result = await modeOfPaymentService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetModeOfPaymentById")]
        public async Task<ActionResult<ModeOfPayment>> GetModeOfPaymentById(int id)
        {
            try
            {
                var result = modeOfPaymentService.GetById(id);
                if (result == null)
                {
                    return NotFound($"ModeOfPayment with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditModeOfPayment")]
        public async Task<ActionResult<ModeOfPayment>> EditModeOfPayment(ModeOfPayment modeOfPayment)
        {
            var result = await modeOfPaymentService.Update(modeOfPayment);
            return result;
        }
        [HttpPost("CreateTaxesAndCharges")]
        public async Task<ActionResult<TaxesAndCharges>> CreateTaxesAndCharges(TaxesAndCharges taxes)
        {
            var result = await taxesAndChargesService.AddAsync(taxes);
            return result;
        }

        [HttpGet("GetAllTaxesAndCharges")]
        public async Task<ActionResult<List<TaxesAndCharges>>> GetAllTaxesAndCharges()
        {
            var result = await taxesAndChargesService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetTaxesAndChargesById")]
        public async Task<ActionResult<TaxesAndCharges>> GetTaxesAndChargesById(int id)
        {
            try
            {
                var result = taxesAndChargesService.GetById(id);
                if (result == null)
                {
                    return NotFound($"TaxesAndCharges with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditTaxesAndCharges")]
        public async Task<ActionResult<TaxesAndCharges>> EditTaxesAndCharges(TaxesAndCharges taxes)
        {
            var result = await taxesAndChargesService.Update(taxes);
            return result;
        }
    }
}
