using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordAPI.Migrations
{
    public partial class InitialMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Records_RecordID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_RecordID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "RecordID",
                table: "Comments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecordID",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_RecordID",
                table: "Comments",
                column: "RecordID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Records_RecordID",
                table: "Comments",
                column: "RecordID",
                principalTable: "Records",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
