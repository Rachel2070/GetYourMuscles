using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM_Management.Data.Migrations
{
    public partial class connect_equetment_to_staff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipmentStaff",
                columns: table => new
                {
                    EquipmentInCategoryId = table.Column<int>(type: "int", nullable: false),
                    StaffsWorker_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentStaff", x => new { x.EquipmentInCategoryId, x.StaffsWorker_Number });
                    table.ForeignKey(
                        name: "FK_EquipmentStaff_GymEquipment_EquipmentInCategoryId",
                        column: x => x.EquipmentInCategoryId,
                        principalTable: "GymEquipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentStaff_GymStaff_StaffsWorker_Number",
                        column: x => x.StaffsWorker_Number,
                        principalTable: "GymStaff",
                        principalColumn: "Worker_Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentStaff_StaffsWorker_Number",
                table: "EquipmentStaff",
                column: "StaffsWorker_Number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentStaff");
        }
    }
}
