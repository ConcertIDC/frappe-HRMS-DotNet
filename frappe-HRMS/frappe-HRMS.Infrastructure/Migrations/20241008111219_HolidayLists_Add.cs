using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frappe_HRMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class HolidayLists_Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeAttendanceLeavesId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeAttendanceLeaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceDeviceID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HolidayListId = table.Column<int>(type: "int", nullable: true),
                    ShiftTypeId = table.Column<int>(type: "int", nullable: true),
                    ExpenseApproverId = table.Column<int>(type: "int", nullable: true),
                    ShiftRequestApproverId = table.Column<int>(type: "int", nullable: true),
                    LeaveApproverId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAttendanceLeaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeAttendanceLeaves_ShiftTypes_HolidayListId",
                        column: x => x.HolidayListId,
                        principalTable: "ShiftTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAttendanceLeaves_ShiftTypes_ShiftTypeId",
                        column: x => x.ShiftTypeId,
                        principalTable: "ShiftTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAttendanceLeaves_Users_ExpenseApproverId",
                        column: x => x.ExpenseApproverId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAttendanceLeaves_Users_LeaveApproverId",
                        column: x => x.LeaveApproverId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAttendanceLeaves_Users_ShiftRequestApproverId",
                        column: x => x.ShiftRequestApproverId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExpenseClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseClaims_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExpenseClaims_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HolidayList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HolidayListName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalHolidays = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayList", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeAttendanceLeavesId",
                table: "Employee",
                column: "EmployeeAttendanceLeavesId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAttendanceLeaves_ExpenseApproverId",
                table: "EmployeeAttendanceLeaves",
                column: "ExpenseApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAttendanceLeaves_HolidayListId",
                table: "EmployeeAttendanceLeaves",
                column: "HolidayListId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAttendanceLeaves_LeaveApproverId",
                table: "EmployeeAttendanceLeaves",
                column: "LeaveApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAttendanceLeaves_ShiftRequestApproverId",
                table: "EmployeeAttendanceLeaves",
                column: "ShiftRequestApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAttendanceLeaves_ShiftTypeId",
                table: "EmployeeAttendanceLeaves",
                column: "ShiftTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaims_CompanyId",
                table: "ExpenseClaims",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaims_EmployeeId",
                table: "ExpenseClaims",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeAttendanceLeaves_EmployeeAttendanceLeavesId",
                table: "Employee",
                column: "EmployeeAttendanceLeavesId",
                principalTable: "EmployeeAttendanceLeaves",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeAttendanceLeaves_EmployeeAttendanceLeavesId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeAttendanceLeaves");

            migrationBuilder.DropTable(
                name: "ExpenseClaims");

            migrationBuilder.DropTable(
                name: "HolidayList");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmployeeAttendanceLeavesId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeAttendanceLeavesId",
                table: "Employee");
        }
    }
}
