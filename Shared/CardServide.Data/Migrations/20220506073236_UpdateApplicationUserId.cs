using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CardServide.Data.Migrations
{
    public partial class UpdateApplicationUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_AspNetUsers_ApplicationUserId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_ApplicationUserId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "ApplicationUser",
                table: "Cards");

            migrationBuilder.AlterColumn<Guid>(
                name: "ApplicationUserId",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Cards",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ApplicationUserId1",
                table: "Cards",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_AspNetUsers_ApplicationUserId1",
                table: "Cards",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_AspNetUsers_ApplicationUserId1",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_ApplicationUserId1",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Cards");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Cards",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUser",
                table: "Cards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ApplicationUserId",
                table: "Cards",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_AspNetUsers_ApplicationUserId",
                table: "Cards",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
