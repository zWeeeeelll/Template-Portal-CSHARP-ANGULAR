using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Data.Migrations
{
    public partial class UpdataDataTables34323342323 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Sales",
                table: "Opportunity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ForecastDate", "NextRelationshipDate", "ValidityDate" },
                values: new object[] { new DateTime(2023, 7, 4, 22, 7, 56, 643, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 3, 26, 22, 7, 56, 643, DateTimeKind.Local).AddTicks(7766), new DateTime(2023, 12, 16, 22, 7, 56, 643, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 22, 7, 56, 622, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 22, 7, 56, 622, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 22, 7, 56, 622, DateTimeKind.Local).AddTicks(3468));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Sales",
                table: "Opportunity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ForecastDate", "NextRelationshipDate", "ValidityDate" },
                values: new object[] { new DateTime(2023, 7, 4, 21, 56, 39, 171, DateTimeKind.Local).AddTicks(696), new DateTime(2023, 3, 26, 21, 56, 39, 171, DateTimeKind.Local).AddTicks(650), new DateTime(2023, 12, 16, 21, 56, 39, 171, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 21, 56, 39, 148, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 21, 56, 39, 148, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 21, 56, 39, 148, DateTimeKind.Local).AddTicks(4380));
        }
    }
}
