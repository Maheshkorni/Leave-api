using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LmsApi.Migrations
{
    public partial class initLMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leave_Table",
                columns: table => new
                {
                    leaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeId = table.Column<int>(type: "int", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    leaveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    managerComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    appliedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave_Table", x => x.leaveId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leave_Table");
        }
    }
}
