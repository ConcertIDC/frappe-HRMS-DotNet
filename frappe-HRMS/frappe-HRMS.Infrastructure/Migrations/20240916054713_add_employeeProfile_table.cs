using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frappe_HRMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_employeeProfile_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EducationalQualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfPassing = table.Column<int>(type: "int", nullable: true),
                    Percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MajorSubjects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalQualifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeHistory_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeHistory_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeHistory_Designation_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PreviousWorkExperience",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalExperience = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousWorkExperience", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BioCoverLetter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationalQualificationId = table.Column<int>(type: "int", nullable: true),
                    PreviousWorkExperienceId = table.Column<int>(type: "int", nullable: true),
                    EmployeeHistoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeProfiles_EducationalQualifications_EducationalQualificationId",
                        column: x => x.EducationalQualificationId,
                        principalTable: "EducationalQualifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeProfiles_EmployeeHistory_EmployeeHistoryId",
                        column: x => x.EmployeeHistoryId,
                        principalTable: "EmployeeHistory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeProfiles_PreviousWorkExperience_PreviousWorkExperienceId",
                        column: x => x.PreviousWorkExperienceId,
                        principalTable: "PreviousWorkExperience",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ProfileId",
                table: "Employee",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHistory_BranchId",
                table: "EmployeeHistory",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHistory_DepartmentId",
                table: "EmployeeHistory",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHistory_DesignationId",
                table: "EmployeeHistory",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfiles_EducationalQualificationId",
                table: "EmployeeProfiles",
                column: "EducationalQualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfiles_EmployeeHistoryId",
                table: "EmployeeProfiles",
                column: "EmployeeHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfiles_PreviousWorkExperienceId",
                table: "EmployeeProfiles",
                column: "PreviousWorkExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeProfiles_ProfileId",
                table: "Employee",
                column: "ProfileId",
                principalTable: "EmployeeProfiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeProfiles_ProfileId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeProfiles");

            migrationBuilder.DropTable(
                name: "EducationalQualifications");

            migrationBuilder.DropTable(
                name: "EmployeeHistory");

            migrationBuilder.DropTable(
                name: "PreviousWorkExperience");

            migrationBuilder.DropIndex(
                name: "IX_Employee_ProfileId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Employee");
        }
    }
}
