using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frappe_HRMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Employee_Related_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_NewJobApplicant_JobApplicantId",
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
                name: "Mobile",
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

            migrationBuilder.RenameColumn(
                name: "NoticeDays",
                table: "Employee",
                newName: "PersonalId");

            migrationBuilder.RenameColumn(
                name: "JobApplicantId",
                table: "Employee",
                newName: "ExitId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_JobApplicantId",
                table: "Employee",
                newName: "IX_Employee_ExitId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeAddressId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeSalaryId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmplyeeJoiningId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CostCenters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostCenterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostCenterNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCostCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    IsGroup = table.Column<bool>(type: "bit", nullable: true),
                    Disabled = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCenters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostCenters_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferedContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAddressIs = table.Column<bool>(type: "bit", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddressIs = table.Column<bool>(type: "bit", nullable: true),
                    EmergencyContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmplyeeJoiningDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobApplicantId = table.Column<int>(type: "int", nullable: true),
                    ConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoticeDays = table.Column<int>(type: "int", nullable: true),
                    OfferDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfRetirement = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmplyeeJoiningDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmplyeeJoiningDetails_NewJobApplicant_JobApplicantId",
                        column: x => x.JobApplicantId,
                        principalTable: "NewJobApplicant",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Exits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResignationLetterDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExitInterviewHeldOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaveEncashed = table.Column<bool>(type: "bit", nullable: true),
                    RelievingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NewWorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonforLeaving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyBackground = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthInsuranceProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceofIssue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofIssue = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValidUpto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CTC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostCenterId = table.Column<int>(type: "int", nullable: true),
                    SalaryCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PANNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvidentFundAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSalaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeSalaries_CostCenters_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeAddressId",
                table: "Employee",
                column: "EmployeeAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeSalaryId",
                table: "Employee",
                column: "EmployeeSalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmplyeeJoiningId",
                table: "Employee",
                column: "EmplyeeJoiningId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PersonalId",
                table: "Employee",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenters_CompanyId",
                table: "CostCenters",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSalaries_CostCenterId",
                table: "EmployeeSalaries",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_EmplyeeJoiningDetails_JobApplicantId",
                table: "EmplyeeJoiningDetails",
                column: "JobApplicantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeAddresses_EmployeeAddressId",
                table: "Employee",
                column: "EmployeeAddressId",
                principalTable: "EmployeeAddresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeSalaries_EmployeeSalaryId",
                table: "Employee",
                column: "EmployeeSalaryId",
                principalTable: "EmployeeSalaries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmplyeeJoiningDetails_EmplyeeJoiningId",
                table: "Employee",
                column: "EmplyeeJoiningId",
                principalTable: "EmplyeeJoiningDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Exits_ExitId",
                table: "Employee",
                column: "ExitId",
                principalTable: "Exits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_PersonalDetails_PersonalId",
                table: "Employee",
                column: "PersonalId",
                principalTable: "PersonalDetails",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeAddresses_EmployeeAddressId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeSalaries_EmployeeSalaryId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmplyeeJoiningDetails_EmplyeeJoiningId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Exits_ExitId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_PersonalDetails_PersonalId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeAddresses");

            migrationBuilder.DropTable(
                name: "EmployeeSalaries");

            migrationBuilder.DropTable(
                name: "EmplyeeJoiningDetails");

            migrationBuilder.DropTable(
                name: "Exits");

            migrationBuilder.DropTable(
                name: "PersonalDetails");

            migrationBuilder.DropTable(
                name: "CostCenters");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmployeeAddressId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmployeeSalaryId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmplyeeJoiningId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_PersonalId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeAddressId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeSalaryId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmplyeeJoiningId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Employee",
                newName: "NoticeDays");

            migrationBuilder.RenameColumn(
                name: "ExitId",
                table: "Employee",
                newName: "JobApplicantId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_ExitId",
                table: "Employee",
                newName: "IX_Employee_JobApplicantId");

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

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Employee",
                type: "nvarchar(max)",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_NewJobApplicant_JobApplicantId",
                table: "Employee",
                column: "JobApplicantId",
                principalTable: "NewJobApplicant",
                principalColumn: "Id");
        }
    }
}
