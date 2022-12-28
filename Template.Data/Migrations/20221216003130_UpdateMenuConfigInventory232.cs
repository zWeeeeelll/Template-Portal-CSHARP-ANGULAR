using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Data.Migrations
{
    public partial class UpdateMenuConfigInventory232 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: 8,
                column: "Icon",
                value: "pi pi-cart-plus");

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: 9,
                column: "Icon",
                value: "pi pi-gift");

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Icon", "IsActive", "ModuleItemId", "Name", "URL" },
                values: new object[] { "pi pi-shopping-cart", true, 5, "Gerenciar", "inventory/manager" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsActive", "ModuleItemId", "URL" },
                values: new object[] { false, 6, "products/list" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ModuleItemId", "URL" },
                values: new object[] { 7, "clients/list" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ModuleItemId", "URL" },
                values: new object[] { 8, "opportunities/list" });

            migrationBuilder.InsertData(
                schema: "Usr",
                table: "ModuleMenu",
                columns: new[] { "Id", "CreatedUser", "Icon", "IsActive", "ModuleItemId", "Name", "Sequence", "URL", "UpdatedData", "UpdatedUser" },
                values: new object[] { 14, 0, "pi pi-eye", true, 9, "Visualizar", 14, "orders/list", null, 0 });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 15, 21, 31, 25, 5, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 15, 21, 31, 25, 5, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 15, 21, 31, 25, 5, DateTimeKind.Local).AddTicks(4217));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: 8,
                column: "Icon",
                value: "pi pi-send");

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: 9,
                column: "Icon",
                value: "pi pi-dollar");

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Icon", "IsActive", "ModuleItemId", "Name", "URL" },
                values: new object[] { "pi pi-eye", false, 6, "Visualizar", "products/list" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsActive", "ModuleItemId", "URL" },
                values: new object[] { true, 7, "clients/list" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ModuleItemId", "URL" },
                values: new object[] { 8, "opportunities/list" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ModuleItemId", "URL" },
                values: new object[] { 9, "orders/list" });

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
    }
}
