using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces;
using frappe_HRMS.Services.Interfaces.Company;
using frappe_HRMS.Services.Interfaces.Employee;
using frappe_HRMS.Services.Services;
using frappe_HRMS.Services.Services.Company;
using frappe_HRMS.Services.Services.Employee;
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
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ISignupRepository, SignupRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IBranchRepository, BranchRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IDesignationRepository,DesignationRepository>();
builder.Services.AddScoped<IEmploymentTypeRepository, EmploymentTypeRepository>();
builder.Services.AddScoped<IEmployeeGradeRepository, EmployeeGradeRepository>();
builder.Services.AddScoped<IEmployeeGroupRepository, EmployeeGroupRepository>();
builder.Services.AddScoped<INewJobApplicantRepository, NewJobApplicantRepository>();
builder.Services.AddScoped<INewJobOpeningRepository, NewJobOpeningRepository>();
builder.Services.AddScoped<IEmployeeAddressRepository, EmployeeAddressRepository>();
builder.Services.AddScoped<IEmployeeJoiningRepository, EmployeeJoiningRepository>();
builder.Services.AddScoped<IEmployeeSalaryRepository, EmployeeSalaryRepository>();
builder.Services.AddScoped<IExitRepository, ExitRepository>();
builder.Services.AddScoped<ICostCenterRepository,  CostCenterRepository>();
builder.Services.AddScoped<IEmployeePersonalRepository, EmployeePersonalRepository>();
builder.Services.AddScoped<IEmployeeProfileRepository, EmployeeProfileRepository>();
builder.Services.AddScoped<IEducationalQualificationRepository, EducationalQualificationRepository>();
builder.Services.AddScoped<IPreviousWorkExperienceRepository, PreviousWorkExperienceRepository>();
builder.Services.AddScoped<IEmployeeHistoryRepository, EmployeeHistoryRepository>();
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
