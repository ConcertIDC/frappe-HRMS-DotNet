using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frappe_HRMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_company_properties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArrearComponent",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BasicComponent",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DefaultBuyingTerms",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DefaultEmployeeAdvanceAccount",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DefaultOperatingCostAccount",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DefaultSellingTerms",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DefaultWarehouseSalesReturn",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HRAComponent",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MonthlySalesTarget",
                table: "Company",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrearComponent",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "BasicComponent",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "DefaultBuyingTerms",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "DefaultEmployeeAdvanceAccount",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "DefaultOperatingCostAccount",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "DefaultSellingTerms",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "DefaultWarehouseSalesReturn",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "HRAComponent",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "MonthlySalesTarget",
                table: "Company");
        }
    }
}
