using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM_Management.Data.Migrations
{
    public partial class create_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GymEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Check = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Test_Frequencies = table.Column<int>(type: "int", nullable: false),
                    Expiry_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GymStaff",
                columns: table => new
                {
                    Worker_Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personal_Id = table.Column<int>(type: "int", nullable: false),
                    Birth_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymStaff", x => x.Worker_Number);
                });

            migrationBuilder.CreateTable(
                name: "GymSubscribers",
                columns: table => new
                {
                    Subscription_Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personal_Id = table.Column<int>(type: "int", nullable: false),
                    Birth_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start_Subscription_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Subscription_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffWorker_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymSubscribers", x => x.Subscription_Number);
                    table.ForeignKey(
                        name: "FK_GymSubscribers_GymStaff_StaffWorker_Number",
                        column: x => x.StaffWorker_Number,
                        principalTable: "GymStaff",
                        principalColumn: "Worker_Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GymSubscribers_StaffWorker_Number",
                table: "GymSubscribers",
                column: "StaffWorker_Number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GymEquipment");

            migrationBuilder.DropTable(
                name: "GymSubscribers");

            migrationBuilder.DropTable(
                name: "GymStaff");
        }
    }
}
