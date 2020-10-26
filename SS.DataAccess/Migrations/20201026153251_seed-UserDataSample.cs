using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SS.DataAccess.Migrations
{
    public partial class seedUserDataSample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 22, 32, 50, 856, DateTimeKind.Local).AddTicks(7904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 26, 21, 44, 28, 864, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 22, 32, 50, 852, DateTimeKind.Local).AddTicks(716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 26, 21, 44, 28, 859, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[] { "Home Title", "This is home Page Sufee" });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0B39A049-7277-4F28-9DDF-148907D7F987", "8d0a3af2-97e4-446a-8779-da6f977f0251", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3973E3F1-086C-4AFF-B484-431013385161", 0, new DateTime(1998, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "14c4237e-42ca-4b9d-84de-2b801d1f7f53", "hqtruong27@gmail.com", true, "Hoang Truong", false, null, "hqtruong27@gmail.com", "Hqtruong27", "AQAAAAEAACcQAAAAEFAFFzQaHeJmGnSbBPu2E4a+LCSLvwHFm3xk/7HZQU8xE/mrhXBc9YquiuO5+VA9cA==", null, false, "", false, "Hqtruong27" });

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
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "3973E3F1-086C-4AFF-B484-431013385161", "0B39A049-7277-4F28-9DDF-148907D7F987" });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "vi-VN", "Iphone", "iphone", "Danh mục Iphone", "Danh mục Iphone" },
                    { 2, 1, "en-US", "Iphone", "iphone", "Category Iphone", "Category Iphone" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Price", "PriceIn" },
                values: new object[] { 1, 1, new DateTime(2020, 10, 26, 22, 32, 50, 866, DateTimeKind.Local).AddTicks(2150), 12000m, 10000m });

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
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3973E3F1-086C-4AFF-B484-431013385161", "0B39A049-7277-4F28-9DDF-148907D7F987" });

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
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "0B39A049-7277-4F28-9DDF-148907D7F987");

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: "3973E3F1-086C-4AFF-B484-431013385161");

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
                name: "DateCreated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 21, 44, 28, 864, DateTimeKind.Local).AddTicks(2743),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 26, 22, 32, 50, 856, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 21, 44, 28, 859, DateTimeKind.Local).AddTicks(4507),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 26, 22, 32, 50, 852, DateTimeKind.Local).AddTicks(716));
        }
    }
}
