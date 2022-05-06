using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CardServide.Data.Migrations
{
    public partial class UpdateApplicationId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Cards");

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUser",
                table: "Cards",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUser",
                table: "Cards");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Cards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
