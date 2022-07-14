using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LmsApi.Migrations
{
    public partial class initLMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_table",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaveBalance = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_table", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Leave_Table",
                columns: table => new
                {
                    leaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    leaveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    managerComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    appliedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave_Table", x => x.leaveId);
                    table.ForeignKey(
                        name: "FK_Leave_Table_Employee_table_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee_table",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leave_Table_EmployeeId",
                table: "Leave_Table",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leave_Table");

            migrationBuilder.DropTable(
                name: "Employee_table");
        }
    }
}
