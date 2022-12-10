using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Data.Migrations
{
    public partial class SeedDataUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Usr",
                table: "Module",
                columns: new[] { "Id", "CreatedUser", "Icon", "IsActive", "Name", "Sequence", "URL", "UpdatedData", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, 0, "dashboard.png", true, "Dashboard", 1, "dashboard", null, 0 },
                    { 2, 0, "users.png", true, "Users", 2, "users", null, 0 },
                    { 3, 0, "accounts.png", true, "Account", 3, "accounts", null, 0 }
                });

            migrationBuilder.InsertData(
                schema: "Usr",
                table: "Profile",
                columns: new[] { "Id", "CreatedUser", "IsActive", "IsDefault", "Name", "UpdatedData", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, 0, true, false, "Admin", null, 0 },
                    { 2, 0, true, true, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                schema: "Usr",
                table: "ModuleProfile",
                columns: new[] { "ModuleId", "ProfileId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 3, 1 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                schema: "Usr",
                table: "User",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Email", "IsActive", "IsAuthorised", "Name", "Password", "ProfileId", "UpdatedData", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 12, 9, 21, 49, 30, 246, DateTimeKind.Local).AddTicks(6893), 1, "admin@template.com", true, true, "Admin", "8D66A53A381493BEC08DA23CEF5A43767F20A42C", 1, null, 0 },
                    { 2, null, new DateTime(2022, 12, 9, 21, 49, 30, 246, DateTimeKind.Local).AddTicks(6906), 1, "user@template.com", true, true, "User", "8D66A53A381493BEC08DA23CEF5A43767F20A42C", 2, null, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "ModuleProfile",
                keyColumns: new[] { "ModuleId", "ProfileId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "ModuleProfile",
                keyColumns: new[] { "ModuleId", "ProfileId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "ModuleProfile",
                keyColumns: new[] { "ModuleId", "ProfileId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "ModuleProfile",
                keyColumns: new[] { "ModuleId", "ProfileId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "ModuleProfile",
                keyColumns: new[] { "ModuleId", "ProfileId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "Module",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "Module",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "Module",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "Profile",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "Profile",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
