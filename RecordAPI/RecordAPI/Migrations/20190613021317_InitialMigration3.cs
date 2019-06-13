using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordAPI.Migrations
{
    public partial class InitialMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Comments_CommentID",
                table: "Records");

            migrationBuilder.RenameColumn(
                name: "CommentID",
                table: "Records",
                newName: "CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_Records_CommentID",
                table: "Records",
                newName: "IX_Records_CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Comments_CommentId",
                table: "Records",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Comments_CommentId",
                table: "Records");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Records",
                newName: "CommentID");

            migrationBuilder.RenameIndex(
                name: "IX_Records_CommentId",
                table: "Records",
                newName: "IX_Records_CommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Comments_CommentID",
                table: "Records",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
