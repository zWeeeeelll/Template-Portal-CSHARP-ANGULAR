using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Data.Migrations
{
    public partial class stages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "Sequence",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Icon", "Name", "Sequence", "URL" },
                values: new object[] { "pi pi-shopping-cart", "Produtos", 5, "config/products" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Icon", "IsActive", "ModuleItemId", "Name", "Sequence", "URL" },
                values: new object[] { "pi pi-file-import", false, 3, "Importações", 6, "config/imports" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Icon", "ModuleItemId", "Name", "Sequence", "URL" },
                values: new object[] { "pi pi-directions", 3, "Stages", 7, "config/stages" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Icon", "ModuleItemId", "Name", "Sequence", "URL" },
                values: new object[] { "pi pi-shopping-cart", 4, "Produtos", 8, "registrations/products" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Icon", "ModuleItemId", "Name", "Sequence", "URL" },
                values: new object[] { "pi pi-shopping-cart", 5, "Produtos", 9, "inventory/products" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ModuleItemId", "Sequence", "URL" },
                values: new object[] { 6, 10, "products/list" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ModuleItemId", "Sequence", "URL" },
                values: new object[] { 7, 11, "clients/list" });

            migrationBuilder.InsertData(
                schema: "Usr",
                table: "ModuleMenu",
                columns: new[] { "Id", "CreatedUser", "Icon", "IsActive", "ModuleItemId", "Name", "Sequence", "URL", "UpdatedData", "UpdatedUser" },
                values: new object[,]
                {
                    { 12, 0, "pi pi-eye", true, 8, "Visualizar", 12, "opportunities/list", null, 0 },
                    { 13, 0, "pi pi-eye", true, 9, "Visualizar", 13, "orders/list", null, 0 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "Sequence",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Icon", "Name", "Sequence", "URL" },
                values: new object[] { "pi pi-file-import", "Importações", 3, "config/imports" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Icon", "IsActive", "ModuleItemId", "Name", "Sequence", "URL" },
                values: new object[] { "pi pi-shopping-cart", true, 4, "Produtos", 4, "registrations/products" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Icon", "ModuleItemId", "Name", "Sequence", "URL" },
                values: new object[] { "pi pi-shopping-cart", 5, "Produtos", 4, "inventory/products" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Icon", "ModuleItemId", "Name", "Sequence", "URL" },
                values: new object[] { "pi pi-eye", 6, "Visualizar", 5, "products/list" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Icon", "ModuleItemId", "Name", "Sequence", "URL" },
                values: new object[] { "pi pi-eye", 7, "Visualizar", 6, "clients/list" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ModuleItemId", "Sequence", "URL" },
                values: new object[] { 8, 7, "opportunities/list" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ModuleItemId", "Sequence", "URL" },
                values: new object[] { 9, 8, "orders/list" });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 14, 21, 42, 16, 132, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 14, 21, 42, 16, 132, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 14, 21, 42, 16, 132, DateTimeKind.Local).AddTicks(808));
        }
    }
}
