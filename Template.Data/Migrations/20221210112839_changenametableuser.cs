using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Data.Migrations
{
    public partial class changenametableuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunity_User_UserId",
                schema: "Sales",
                table: "Opportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Profile_ProfileId",
                schema: "Usr",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                schema: "Usr",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "Usr",
                newName: "Users",
                newSchema: "Usr");

            migrationBuilder.RenameIndex(
                name: "IX_User_ProfileId",
                schema: "Usr",
                table: "Users",
                newName: "IX_Users_ProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "Usr",
                table: "Users",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 8, 28, 36, 16, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 8, 28, 36, 16, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunity_Users_UserId",
                schema: "Sales",
                table: "Opportunity",
                column: "UserId",
                principalSchema: "Usr",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Profile_ProfileId",
                schema: "Usr",
                table: "Users",
                column: "ProfileId",
                principalSchema: "Usr",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunity_Users_UserId",
                schema: "Sales",
                table: "Opportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Profile_ProfileId",
                schema: "Usr",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "Usr",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "Usr",
                newName: "User",
                newSchema: "Usr");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ProfileId",
                schema: "Usr",
                table: "User",
                newName: "IX_User_ProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                schema: "Usr",
                table: "User",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 21, 49, 30, 246, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 21, 49, 30, 246, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunity_User_UserId",
                schema: "Sales",
                table: "Opportunity",
                column: "UserId",
                principalSchema: "Usr",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Profile_ProfileId",
                schema: "Usr",
                table: "User",
                column: "ProfileId",
                principalSchema: "Usr",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
