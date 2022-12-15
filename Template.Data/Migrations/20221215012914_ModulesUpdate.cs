using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Data.Migrations
{
    public partial class ModulesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Icon", "Name", "URL" },
                values: new object[] { "pi pi-id-card", "Acessos", "users/access" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 14, 22, 29, 10, 565, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 14, 22, 29, 10, 565, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 14, 22, 29, 10, 565, DateTimeKind.Local).AddTicks(1276));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Icon", "Name", "URL" },
                values: new object[] { "pi pi-eye", "Visualizar", "users/list" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 14, 22, 22, 29, 959, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 14, 22, 22, 29, 959, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 14, 22, 22, 29, 959, DateTimeKind.Local).AddTicks(2871));
        }
    }
}
