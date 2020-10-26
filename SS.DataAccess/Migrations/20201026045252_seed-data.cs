using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SS.DataAccess.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeatCreated",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 11, 52, 52, 56, DateTimeKind.Local).AddTicks(5326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 26, 10, 57, 27, 847, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 11, 52, 52, 45, DateTimeKind.Local).AddTicks(3753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 26, 10, 57, 27, 839, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[] { "Home Title", "This is home Page Sufee" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder", "Status" },
                values: new object[] { 1, true, null, 1, 1 });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Vietnamese" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { 1, 1, "vi-VN", "Iphone", "iphone", "Danh mục Iphone", "Danh mục Iphone" });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { 2, 1, "en-US", "Iphone", "iphone", "Category Iphone", "Category Iphone" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DeatCreated", "Price", "PriceIn" },
                values: new object[] { 1, 1, new DateTime(2020, 10, 26, 11, 52, 52, 63, DateTimeKind.Local).AddTicks(4216), 12000m, 10000m });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { 1, "VN", "Mô tả về ip 7", "vi-VN", "Iphone 7", 1, "iphone-7", "Đây là Iphone 7", "sản phẩm Iphone 7" });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { 2, "EN", "Description Ip 7", "en-US", "Iphone 7", 1, "iphone-7", "This is Iphone 7", "This is Iphone 7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Home Title");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeatCreated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 10, 57, 27, 847, DateTimeKind.Local).AddTicks(5788),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 26, 11, 52, 52, 56, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 10, 57, 27, 839, DateTimeKind.Local).AddTicks(1219),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 26, 11, 52, 52, 45, DateTimeKind.Local).AddTicks(3753));
        }
    }
}
