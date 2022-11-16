using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DateTimeComponents.Server.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Employees",
                newName: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Time",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Employees",
                newName: "Date");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Time",
                table: "Employees",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
