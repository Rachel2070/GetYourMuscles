using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM_Management.Data.Migrations
{
    public partial class add_staffId_to_subscriber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymSubscribers_GymStaff_StaffWorker_Number",
                table: "GymSubscribers");

            migrationBuilder.RenameColumn(
                name: "StaffWorker_Number",
                table: "GymSubscribers",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_GymSubscribers_StaffWorker_Number",
                table: "GymSubscribers",
                newName: "IX_GymSubscribers_StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_GymSubscribers_GymStaff_StaffId",
                table: "GymSubscribers",
                column: "StaffId",
                principalTable: "GymStaff",
                principalColumn: "Worker_Number",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymSubscribers_GymStaff_StaffId",
                table: "GymSubscribers");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "GymSubscribers",
                newName: "StaffWorker_Number");

            migrationBuilder.RenameIndex(
                name: "IX_GymSubscribers_StaffId",
                table: "GymSubscribers",
                newName: "IX_GymSubscribers_StaffWorker_Number");

            migrationBuilder.AddForeignKey(
                name: "FK_GymSubscribers_GymStaff_StaffWorker_Number",
                table: "GymSubscribers",
                column: "StaffWorker_Number",
                principalTable: "GymStaff",
                principalColumn: "Worker_Number",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
