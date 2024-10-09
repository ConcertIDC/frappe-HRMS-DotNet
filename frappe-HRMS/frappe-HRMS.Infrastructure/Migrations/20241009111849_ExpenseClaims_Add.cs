using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frappe_HRMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ExpenseClaims_Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "PreviousWorkExperience",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccountingDetailsId",
                table: "ExpenseClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpenseClaimId",
                table: "ExpenseClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ExpenseClaims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeeHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EducationalQualifications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ExpenseClaimTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseClaimTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    SanctionAmount = table.Column<int>(type: "int", nullable: true),
                    ExpenseClaimTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_ExpenseClaimTypes_ExpenseClaimTypeId",
                        column: x => x.ExpenseClaimTypeId,
                        principalTable: "ExpenseClaimTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPaid = table.Column<bool>(type: "bit", nullable: true),
                    ClearanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostCenterId = table.Column<int>(type: "int", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountingDetails_CostCenters_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountingDetails_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreviousWorkExperience_EmployeeId",
                table: "PreviousWorkExperience",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaims_AccountingDetailsId",
                table: "ExpenseClaims",
                column: "AccountingDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaims_ExpenseClaimId",
                table: "ExpenseClaims",
                column: "ExpenseClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHistory_EmployeeId",
                table: "EmployeeHistory",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalQualifications_EmployeeId",
                table: "EducationalQualifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountingDetails_CostCenterId",
                table: "AccountingDetails",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountingDetails_ProjectId",
                table: "AccountingDetails",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseClaimTypeId",
                table: "Expenses",
                column: "ExpenseClaimTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CompanyId",
                table: "Projects",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalQualifications_Employee_EmployeeId",
                table: "EducationalQualifications",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeHistory_Employee_EmployeeId",
                table: "EmployeeHistory",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseClaims_AccountingDetails_AccountingDetailsId",
                table: "ExpenseClaims",
                column: "AccountingDetailsId",
                principalTable: "AccountingDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseClaims_ExpenseClaims_ExpenseClaimId",
                table: "ExpenseClaims",
                column: "ExpenseClaimId",
                principalTable: "ExpenseClaims",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PreviousWorkExperience_Employee_EmployeeId",
                table: "PreviousWorkExperience",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationalQualifications_Employee_EmployeeId",
                table: "EducationalQualifications");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeHistory_Employee_EmployeeId",
                table: "EmployeeHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseClaims_AccountingDetails_AccountingDetailsId",
                table: "ExpenseClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseClaims_ExpenseClaims_ExpenseClaimId",
                table: "ExpenseClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_PreviousWorkExperience_Employee_EmployeeId",
                table: "PreviousWorkExperience");

            migrationBuilder.DropTable(
                name: "AccountingDetails");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "ExpenseClaimTypes");

            migrationBuilder.DropIndex(
                name: "IX_PreviousWorkExperience_EmployeeId",
                table: "PreviousWorkExperience");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseClaims_AccountingDetailsId",
                table: "ExpenseClaims");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseClaims_ExpenseClaimId",
                table: "ExpenseClaims");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeHistory_EmployeeId",
                table: "EmployeeHistory");

            migrationBuilder.DropIndex(
                name: "IX_EducationalQualifications_EmployeeId",
                table: "EducationalQualifications");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "PreviousWorkExperience");

            migrationBuilder.DropColumn(
                name: "AccountingDetailsId",
                table: "ExpenseClaims");

            migrationBuilder.DropColumn(
                name: "ExpenseClaimId",
                table: "ExpenseClaims");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ExpenseClaims");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeHistory");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EducationalQualifications");
        }
    }
}
