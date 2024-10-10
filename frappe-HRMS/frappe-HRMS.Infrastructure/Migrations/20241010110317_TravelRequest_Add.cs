using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frappe_HRMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TravelRequest_Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAttendanceLeaves_ShiftTypes_HolidayListId",
                table: "EmployeeAttendanceLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseClaims_ExpenseClaims_ExpenseClaimId",
                table: "ExpenseClaims");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseClaims_ExpenseClaimId",
                table: "ExpenseClaims");

            migrationBuilder.DropColumn(
                name: "ExpenseClaimId",
                table: "ExpenseClaims");

            migrationBuilder.AddColumn<int>(
                name: "ExpenseClaimId",
                table: "Expenses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CostingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseClaimTypeId = table.Column<int>(type: "int", nullable: false),
                    SponseredAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FundedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelRequestId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostingDetails_ExpenseClaimTypes_ExpenseClaimTypeId",
                        column: x => x.ExpenseClaimTypeId,
                        principalTable: "ExpenseClaimTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationDocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelRequestId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurposeOfTravels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurposeofTravel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelRequestId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurposeOfTravels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelFunding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailsofSponsor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurposeOfTravelId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificationDocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyOtherDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostCenterId = table.Column<int>(type: "int", nullable: true),
                    NameOfOrganizer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressofOrganizer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelRequests_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TravelRequests_CostCenters_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TravelRequests_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TravelRequests_PurposeOfTravels_PurposeOfTravelId",
                        column: x => x.PurposeOfTravelId,
                        principalTable: "PurposeOfTravels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TravelItineraries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeOfTravel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArrivalDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MealPreference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTravelAdvanceRequired = table.Column<bool>(type: "bit", nullable: true),
                    IsLodgingRequired = table.Column<bool>(type: "bit", nullable: true),
                    OtherDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelRequestId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelItineraries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelItineraries_TravelRequests_TravelRequestId",
                        column: x => x.TravelRequestId,
                        principalTable: "TravelRequests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseClaimId",
                table: "Expenses",
                column: "ExpenseClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_CostingDetails_ExpenseClaimTypeId",
                table: "CostingDetails",
                column: "ExpenseClaimTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CostingDetails_TravelRequestId",
                table: "CostingDetails",
                column: "TravelRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTypes_TravelRequestId",
                table: "DocumentTypes",
                column: "TravelRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_PurposeOfTravels_TravelRequestId",
                table: "PurposeOfTravels",
                column: "TravelRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelItineraries_TravelRequestId",
                table: "TravelItineraries",
                column: "TravelRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequests_CompanyId",
                table: "TravelRequests",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequests_CostCenterId",
                table: "TravelRequests",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequests_EmployeeId",
                table: "TravelRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelRequests_PurposeOfTravelId",
                table: "TravelRequests",
                column: "PurposeOfTravelId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAttendanceLeaves_HolidayList_HolidayListId",
                table: "EmployeeAttendanceLeaves",
                column: "HolidayListId",
                principalTable: "HolidayList",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseClaims_ExpenseClaimId",
                table: "Expenses",
                column: "ExpenseClaimId",
                principalTable: "ExpenseClaims",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CostingDetails_TravelRequests_TravelRequestId",
                table: "CostingDetails",
                column: "TravelRequestId",
                principalTable: "TravelRequests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentTypes_TravelRequests_TravelRequestId",
                table: "DocumentTypes",
                column: "TravelRequestId",
                principalTable: "TravelRequests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurposeOfTravels_TravelRequests_TravelRequestId",
                table: "PurposeOfTravels",
                column: "TravelRequestId",
                principalTable: "TravelRequests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAttendanceLeaves_HolidayList_HolidayListId",
                table: "EmployeeAttendanceLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseClaims_ExpenseClaimId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_PurposeOfTravels_TravelRequests_TravelRequestId",
                table: "PurposeOfTravels");

            migrationBuilder.DropTable(
                name: "CostingDetails");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "TravelItineraries");

            migrationBuilder.DropTable(
                name: "TravelRequests");

            migrationBuilder.DropTable(
                name: "PurposeOfTravels");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExpenseClaimId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExpenseClaimId",
                table: "Expenses");

            migrationBuilder.AddColumn<int>(
                name: "ExpenseClaimId",
                table: "ExpenseClaims",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaims_ExpenseClaimId",
                table: "ExpenseClaims",
                column: "ExpenseClaimId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAttendanceLeaves_ShiftTypes_HolidayListId",
                table: "EmployeeAttendanceLeaves",
                column: "HolidayListId",
                principalTable: "ShiftTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseClaims_ExpenseClaims_ExpenseClaimId",
                table: "ExpenseClaims",
                column: "ExpenseClaimId",
                principalTable: "ExpenseClaims",
                principalColumn: "Id");
        }
    }
}
