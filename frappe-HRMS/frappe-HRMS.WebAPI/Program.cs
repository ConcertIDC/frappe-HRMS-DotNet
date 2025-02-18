using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Infrastructure.Repositories;
using frappe_HRMS.Infrastructure.Services.TimeSheet;
using frappe_HRMS.Services.Interfaces;
using frappe_HRMS.Services.Interfaces.Attendance;
using frappe_HRMS.Services.Interfaces.Claim;
using frappe_HRMS.Services.Interfaces.Company;
using frappe_HRMS.Services.Interfaces.Employee;
using frappe_HRMS.Services.Interfaces.Leave;
using frappe_HRMS.Services.Interfaces.Projects;
using frappe_HRMS.Services.Interfaces.TimeSheet;
using frappe_HRMS.Services.Services;
using frappe_HRMS.Services.Services.Attendance;
using frappe_HRMS.Services.Services.Claim;
using frappe_HRMS.Services.Services.Company;
using frappe_HRMS.Services.Services.Employee;
using frappe_HRMS.Services.Services.Leave;
using frappe_HRMS.Services.Services.Projects;
using frappe_HRMS.Services.Services.TimeSheet;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddDbContext<HRMSDbContext>(options =>
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(HRMSDbContext).Assembly.FullName)));
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Secret"])),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});

#region Services
builder.Services.AddScoped<ISignupService, SignupService>();
builder.Services.AddScoped<IAttendanceService,AttendanceService>();
builder.Services.AddScoped<IAttendanceRequestService,AttendanceRequestService>();
builder.Services.AddScoped<IShiftTypeService,ShiftTypeService>();
builder.Services.AddScoped<IEmployeeCheckinService,EmployeeCheckinService>();
builder.Services.AddScoped<IHolidayListService,HolidayListService>();
builder.Services.AddScoped<IBranchService, BranchService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IDesignationService, DesignationService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IEmploymentTypeService, EmploymentTypeService>();
builder.Services.AddScoped<IAccountingDetailsService,AccountingDetailsService>();
builder.Services.AddScoped<IAccountService,AccountService>();
builder.Services.AddScoped<IAdvancePaymentService,AdvancePaymentService>();
builder.Services.AddScoped<IEmployeeAdvanceService, EmployeeAdvanceService>();
builder.Services.AddScoped<IExpenseClaimService,ExpenseClaimService>();
builder.Services.AddScoped<IExpenseClaimTypeService,ExpenseClaimTypeService>();
builder.Services.AddScoped<IExpensesService,ExpensesService>();
builder.Services.AddScoped<IModeOfPaymentService,ModeOfPaymentService>();
builder.Services.AddScoped<IPurposeOfTravelService,PurposeOfTravelService>();
builder.Services.AddScoped<ITaxesAndChargesService,TaxesAndChargesService>();
builder.Services.AddScoped<ITravelItineraryService,TravelItineraryService>();
builder.Services.AddScoped<ITravelRequestService,TravelRequestService>();
builder.Services.AddScoped<ICostCenterService,CostCenterService>();
builder.Services.AddScoped<IEducationalQualificationService,EducationalQualificationService>();
builder.Services.AddScoped<IEmployeeAddressService,EmployeeAddressService>();
builder.Services.AddScoped<IEmployeeAttendanceService,EmployeeAttendanceService>();
builder.Services.AddScoped<IEmployeeGradeService,EmployeeGradeService>();
builder.Services.AddScoped<IEmployeeGroupService,EmployeeGroupService>();
builder.Services.AddScoped<IEmployeeHistoryService,EmployeeHistoryService>();
builder.Services.AddScoped<IEmployeeJoiningService,EmployeeJoiningService>();
builder.Services.AddScoped<IEmployeePersonalService,EmployeePersonalService>();
builder.Services.AddScoped<IEmployeeProfileService,EmployeeProfileService>();
builder.Services.AddScoped<IEmployeeSalaryService,EmployeeSalaryService>();
builder.Services.AddScoped<IEmployeeService,EmployeeService>();
builder.Services.AddScoped<IExitService,ExitService>();
builder.Services.AddScoped<INewJobApplicantService,NewJobApplicantService>();
builder.Services.AddScoped<INewJobOpeningService,NewJobOpeningService>();
builder.Services.AddScoped<IPreviousWorkExperienceService,PreviousWorkExperienceService>();
builder.Services.AddScoped<ICompensatoryLeaveRequestService,CompensatoryLeaveRequestService>();
builder.Services.AddScoped<ILeaveApplicationService,LeaveApplicationService>();
builder.Services.AddScoped<ILeaveTypeService,LeaveTypeService>();
builder.Services.AddScoped<IProjectService,ProjectService>();
builder.Services.AddScoped<IProjectTemplateService,ProjectTemplateService>();
builder.Services.AddScoped<IProjectTypeService,ProjectTypeService>();
builder.Services.AddScoped<IProjectUpdateService,ProjectUpdateService>();
builder.Services.AddScoped<ITaskService,TaskService>();
builder.Services.AddScoped<IActivityTypeService,ActivityTypeService>();
builder.Services.AddScoped<IBillingDetailsService,BillingDetailsService>();
builder.Services.AddScoped<ITimeSheetListService,TimeSheetListService>();
builder.Services.AddScoped<ITimeSheetService,TimeSheetService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
#endregion

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
