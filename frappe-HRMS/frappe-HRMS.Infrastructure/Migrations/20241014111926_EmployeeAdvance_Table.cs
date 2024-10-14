using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frappe_HRMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeAdvance_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BalanceMustbe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disable = table.Column<bool>(type: "bit", nullable: true),
                    IsGroup = table.Column<bool>(type: "bit", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    Currencey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ModeOfPayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeOfPayment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxesAndCharges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    CostCenterId = table.Column<int>(type: "int", nullable: true),
                    AccountHeadId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxesAndCharges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxesAndCharges_Accounts_AccountHeadId",
                        column: x => x.AccountHeadId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxesAndCharges_CostCenters_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxesAndCharges_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAdvances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvanceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ModeOfPaymentId = table.Column<int>(type: "int", nullable: true),
                    RepayUnclaimedAmountfromSalary = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAdvances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeAdvances_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAdvances_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAdvances_ModeOfPayment_ModeOfPaymentId",
                        column: x => x.ModeOfPaymentId,
                        principalTable: "ModeOfPayment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdvancePayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeAdvanceId = table.Column<int>(type: "int", nullable: true),
                    AllocatedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancePayments_EmployeeAdvances_EmployeeAdvanceId",
                        column: x => x.EmployeeAdvanceId,
                        principalTable: "EmployeeAdvances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CompanyId",
                table: "Accounts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayments_EmployeeAdvanceId",
                table: "AdvancePayments",
                column: "EmployeeAdvanceId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAdvances_CompanyId",
                table: "EmployeeAdvances",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAdvances_EmployeeId",
                table: "EmployeeAdvances",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAdvances_ModeOfPaymentId",
                table: "EmployeeAdvances",
                column: "ModeOfPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxesAndCharges_AccountHeadId",
                table: "TaxesAndCharges",
                column: "AccountHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxesAndCharges_CostCenterId",
                table: "TaxesAndCharges",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxesAndCharges_ProjectId",
                table: "TaxesAndCharges",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvancePayments");

            migrationBuilder.DropTable(
                name: "TaxesAndCharges");

            migrationBuilder.DropTable(
                name: "EmployeeAdvances");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ModeOfPayment");
        }
    }
}
