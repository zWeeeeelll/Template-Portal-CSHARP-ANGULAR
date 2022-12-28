using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Data.Migrations
{
    public partial class updateMenuConfigView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 15, 21, 9, 55, 834, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 15, 21, 9, 55, 834, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 15, 21, 9, 55, 834, DateTimeKind.Local).AddTicks(8625));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsActive",
                value: true);

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
    }
}
