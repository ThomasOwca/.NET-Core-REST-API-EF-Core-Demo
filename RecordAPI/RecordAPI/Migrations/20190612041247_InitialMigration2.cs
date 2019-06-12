using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordAPI.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comments_RecordID",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "CommentID",
                table: "Records",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Records_CommentID",
                table: "Records",
                column: "CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_RecordID",
                table: "Comments",
                column: "RecordID");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Comments_CommentID",
                table: "Records",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Comments_CommentID",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_CommentID",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Comments_RecordID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentID",
                table: "Records");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_RecordID",
                table: "Comments",
                column: "RecordID",
                unique: true,
                filter: "[RecordID] IS NOT NULL");
        }
    }
}
