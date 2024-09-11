using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frappe_HRMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_table_NewJobOpeningNewJobApplicant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ConfirmationDate",
                table: "Employee",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractEndDate",
                table: "Employee",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentAddress",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CurrentAddressIs",
                table: "Employee",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfRetirement",
                table: "Employee",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyPhone",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobApplicantId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoticeDays",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OfferDate",
                table: "Employee",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PermanentAddressIs",
                table: "Employee",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonalEmail",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferedContactEmail",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Relation",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NewJobOpening",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    DesignationId = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    EmploymentTypeId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ReportsTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClosesOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PublishOnWebsite = table.Column<bool>(type: "bit", nullable: true),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobApplicationRoute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpperRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishSalaryRange = table.Column<bool>(type: "bit", nullable: true),
                    SalaryPaidPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishApplicationsReceived = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewJobOpening", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewJobOpening_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewJobOpening_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewJobOpening_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewJobOpening_Designation_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewJobOpening_EmploymentType_EmploymentTypeId",
                        column: x => x.EmploymentTypeId,
                        principalTable: "EmploymentType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NewJobApplicant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewJobOpeningId = table.Column<int>(type: "int", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesignationId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverLetter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantRating = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpperRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewJobApplicant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewJobApplicant_Designation_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewJobApplicant_NewJobOpening_NewJobOpeningId",
                        column: x => x.NewJobOpeningId,
                        principalTable: "NewJobOpening",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobApplicantId",
                table: "Employee",
                column: "JobApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_NewJobApplicant_DesignationId",
                table: "NewJobApplicant",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_NewJobApplicant_NewJobOpeningId",
                table: "NewJobApplicant",
                column: "NewJobOpeningId");

            migrationBuilder.CreateIndex(
                name: "IX_NewJobOpening_BranchId",
                table: "NewJobOpening",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_NewJobOpening_CompanyId",
                table: "NewJobOpening",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_NewJobOpening_DepartmentId",
                table: "NewJobOpening",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_NewJobOpening_DesignationId",
                table: "NewJobOpening",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_NewJobOpening_EmploymentTypeId",
                table: "NewJobOpening",
                column: "EmploymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_NewJobApplicant_JobApplicantId",
                table: "Employee",
                column: "JobApplicantId",
                principalTable: "NewJobApplicant",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_NewJobApplicant_JobApplicantId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "NewJobApplicant");

            migrationBuilder.DropTable(
                name: "NewJobOpening");

            migrationBuilder.DropIndex(
                name: "IX_Employee_JobApplicantId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ConfirmationDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ContractEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CurrentAddress",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CurrentAddressIs",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DateOfRetirement",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmergencyContactName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmergencyPhone",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobApplicantId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "NoticeDays",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "OfferDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PermanentAddressIs",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PersonalEmail",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PreferedContactEmail",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Relation",
                table: "Employee");
        }
    }
}
