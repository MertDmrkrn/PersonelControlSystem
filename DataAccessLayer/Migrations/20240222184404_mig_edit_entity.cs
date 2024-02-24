using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_edit_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Personels_ProjectID",
                table: "Personels",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_ShiftID",
                table: "Personels",
                column: "ShiftID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Projects_ProjectID",
                table: "Personels",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ProjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Shifts_ShiftID",
                table: "Personels",
                column: "ShiftID",
                principalTable: "Shifts",
                principalColumn: "ShiftID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Projects_ProjectID",
                table: "Personels");

            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Shifts_ShiftID",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_ProjectID",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_ShiftID",
                table: "Personels");
        }
    }
}
