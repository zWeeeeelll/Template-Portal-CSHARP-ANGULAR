using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Data.Migrations
{
    public partial class seedstables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Annotation_AnnotationType_NoteTypeId",
                schema: "Sales",
                table: "Annotation");

            migrationBuilder.DropForeignKey(
                name: "FK_Annotation_Opportunity_OpportunityId",
                schema: "Sales",
                table: "Annotation");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Company_CompanyId",
                schema: "Person",
                table: "Contact");

            migrationBuilder.RenameColumn(
                name: "Phone",
                schema: "Person",
                table: "Company",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "NoteTypeId",
                schema: "Sales",
                table: "Annotation",
                newName: "AnnotationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Annotation_NoteTypeId",
                schema: "Sales",
                table: "Annotation",
                newName: "IX_Annotation_AnnotationTypeId");

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId",
                schema: "Production",
                table: "ProductSubCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                schema: "Person",
                table: "Contact",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneCode",
                schema: "Person",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpportunityId",
                schema: "Sales",
                table: "Annotation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "Location",
                table: "Address",
                columns: new[] { "Id", "CityId", "Complement", "CountryId", "CreatedUser", "District", "IsActive", "Number", "PostalCode", "StateId", "Street", "UpdatedData", "UpdatedUser" },
                values: new object[] { 1, 4444, null, 1, 0, "Centro", true, "36", "88390000", 24, "1971", null, 0 });

            migrationBuilder.InsertData(
                schema: "Sales",
                table: "Concept",
                columns: new[] { "Id", "CreatedUser", "IsActive", "Name", "UpdatedData", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, 0, true, "Redes sociais", null, 0 },
                    { 2, 0, true, "Em campo", null, 0 },
                    { 3, 0, true, "Email", null, 0 },
                    { 4, 0, true, "Telefonema", null, 0 }
                });

            migrationBuilder.InsertData(
                schema: "Inventory",
                table: "InventoryType",
                columns: new[] { "Id", "CreatedUser", "IsActive", "Name", "UpdatedData", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, 0, true, "Entrada", null, 0 },
                    { 2, 0, true, "Ajuste", null, 0 },
                    { 3, 0, true, "Periódico", null, 0 }
                });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 10,
                column: "Icon",
                value: "pi pi-pencil");

            migrationBuilder.InsertData(
                schema: "Sales",
                table: "OpportunityType",
                columns: new[] { "Id", "CreatedUser", "IsActive", "Name", "UpdatedData", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, 0, true, "Lead", null, 0 },
                    { 2, 0, true, "Venda", null, 0 },
                    { 3, 0, true, "Re-venda", null, 0 },
                    { 4, 0, true, "Recaptação", null, 0 }
                });

            migrationBuilder.InsertData(
                schema: "Production",
                table: "ProductCategory",
                columns: new[] { "Id", "CreatedUser", "IsActive", "Name", "UpdatedData", "UpdatedUser" },
                values: new object[] { 1, 0, true, "Geral", null, 0 });

            migrationBuilder.InsertData(
                schema: "Sales",
                table: "Stage",
                columns: new[] { "Id", "CreatedUser", "IsActive", "Name", "UpdatedData", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, 0, true, "Oportunidade", null, 0 },
                    { 2, 0, true, "Negociação", null, 0 },
                    { 3, 0, true, "Análise", null, 0 },
                    { 4, 0, true, "Produção", null, 0 },
                    { 5, 0, true, "Finalizada", null, 0 },
                    { 6, 0, true, "Cancelada", null, 0 }
                });

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 15, 23, 3, 12, 316, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 15, 23, 3, 12, 316, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 15, 23, 3, 12, 316, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.InsertData(
                schema: "Person",
                table: "Company",
                columns: new[] { "Id", "AddressId", "BusinessName", "CreatedUser", "Email", "IsActive", "Name", "PhoneCode", "PhoneNumber", "UpdatedData", "UpdatedUser" },
                values: new object[] { 1, 1, "Genérico", 0, "isaacestudo1999@gmail.com", true, "Genérico", "47", "999002349", null, 0 });

            migrationBuilder.InsertData(
                schema: "Inventory",
                table: "Inventory",
                columns: new[] { "Id", "CreatedUser", "Description", "InventoryTypeId", "IsActive", "Title", "UpdatedData", "UpdatedUser" },
                values: new object[] { 1, 0, "Teste", 1, true, "Geral", null, 0 });

            migrationBuilder.InsertData(
                schema: "Production",
                table: "ProductSubCategory",
                columns: new[] { "Id", "CreatedUser", "IsActive", "Name", "ProductCategoryId", "UpdatedData", "UpdatedUser" },
                values: new object[] { 1, 0, true, "Geral", 1, null, 0 });

            migrationBuilder.InsertData(
                schema: "Person",
                table: "Contact",
                columns: new[] { "Id", "AddressId", "CompanyId", "CreatedUser", "Email", "IsActive", "Name", "Nickname", "PhoneCode", "PhoneNumber", "UpdatedData", "UpdatedUser" },
                values: new object[] { 1, 1, 1, 0, "isaacestudo1999@gmail.com", true, "Genérico", "Genérico", "47", "999002349", null, 0 });

            migrationBuilder.InsertData(
                schema: "Production",
                table: "Product",
                columns: new[] { "Id", "CreatedUser", "Description", "IsActive", "Name", "ProductCategoryId", "ProductSubCategoryId", "UpdatedData", "UpdatedUser" },
                values: new object[] { 1, 0, null, true, "Genérico", 1, 1, null, 0 });

            migrationBuilder.InsertData(
                schema: "Inventory",
                table: "InventoryItem",
                columns: new[] { "Id", "Barcode", "BuyPrice", "CreatedUser", "InventoryId", "IsActive", "ProductId", "Quantity", "SellPrice", "UpdatedData", "UpdatedUser" },
                values: new object[] { 1, "7889566423", 80.319999999999993, 0, 1, true, 1, 4, 100.23, null, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategory_ProductCategoryId",
                schema: "Production",
                table: "ProductSubCategory",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Annotation_AnnotationType_AnnotationTypeId",
                schema: "Sales",
                table: "Annotation",
                column: "AnnotationTypeId",
                principalSchema: "Sales",
                principalTable: "AnnotationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Annotation_Opportunity_OpportunityId",
                schema: "Sales",
                table: "Annotation",
                column: "OpportunityId",
                principalSchema: "Sales",
                principalTable: "Opportunity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Company_CompanyId",
                schema: "Person",
                table: "Contact",
                column: "CompanyId",
                principalSchema: "Person",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategory_ProductCategory_ProductCategoryId",
                schema: "Production",
                table: "ProductSubCategory",
                column: "ProductCategoryId",
                principalSchema: "Production",
                principalTable: "ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Annotation_AnnotationType_AnnotationTypeId",
                schema: "Sales",
                table: "Annotation");

            migrationBuilder.DropForeignKey(
                name: "FK_Annotation_Opportunity_OpportunityId",
                schema: "Sales",
                table: "Annotation");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Company_CompanyId",
                schema: "Person",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategory_ProductCategory_ProductCategoryId",
                schema: "Production",
                table: "ProductSubCategory");

            migrationBuilder.DropIndex(
                name: "IX_ProductSubCategory_ProductCategoryId",
                schema: "Production",
                table: "ProductSubCategory");

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Concept",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Concept",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Concept",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Concept",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Contact",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Inventory",
                table: "InventoryItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Inventory",
                table: "InventoryType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Inventory",
                table: "InventoryType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "OpportunityType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "OpportunityType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "OpportunityType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "OpportunityType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Stage",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Stage",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Stage",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Stage",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Stage",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Stage",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Company",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Inventory",
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Production",
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Location",
                table: "Address",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Inventory",
                table: "InventoryType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Production",
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Production",
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                schema: "Production",
                table: "ProductSubCategory");

            migrationBuilder.DropColumn(
                name: "PhoneCode",
                schema: "Person",
                table: "Company");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                schema: "Person",
                table: "Company",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "AnnotationTypeId",
                schema: "Sales",
                table: "Annotation",
                newName: "NoteTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Annotation_AnnotationTypeId",
                schema: "Sales",
                table: "Annotation",
                newName: "IX_Annotation_NoteTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                schema: "Person",
                table: "Contact",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OpportunityId",
                schema: "Sales",
                table: "Annotation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                schema: "Usr",
                table: "ModuleMenu",
                keyColumn: "Id",
                keyValue: 10,
                column: "Icon",
                value: "pi pi-shopping-cart");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Annotation_AnnotationType_NoteTypeId",
                schema: "Sales",
                table: "Annotation",
                column: "NoteTypeId",
                principalSchema: "Sales",
                principalTable: "AnnotationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Annotation_Opportunity_OpportunityId",
                schema: "Sales",
                table: "Annotation",
                column: "OpportunityId",
                principalSchema: "Sales",
                principalTable: "Opportunity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Company_CompanyId",
                schema: "Person",
                table: "Contact",
                column: "CompanyId",
                principalSchema: "Person",
                principalTable: "Company",
                principalColumn: "Id");
        }
    }
}
