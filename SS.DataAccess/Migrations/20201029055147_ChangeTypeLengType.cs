using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SS.DataAccess.Migrations
{
    public partial class ChangeTypeLengType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 12, 51, 46, 706, DateTimeKind.Local).AddTicks(8549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 29, 11, 53, 37, 149, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 12, 51, 46, 701, DateTimeKind.Local).AddTicks(8423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 29, 11, 53, 37, 144, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "0B39A049-7277-4F28-9DDF-148907D7F987",
                column: "ConcurrencyStamp",
                value: "efd27fbe-3117-427d-9e78-8d7c30b3364c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: "3973E3F1-086C-4AFF-B484-431013385161",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47797aa3-5771-48b4-b678-8552559dd69e", "AQAAAAEAACcQAAAAEJQmf6h0AE+ghgPA+rknztGpSrwAjqfmTYWCUohscJRtQKE7it6lSZSxJrkKI9TChg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 29, 12, 51, 46, 719, DateTimeKind.Local).AddTicks(7132));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 11, 53, 37, 149, DateTimeKind.Local).AddTicks(4721),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 29, 12, 51, 46, 706, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 11, 53, 37, 144, DateTimeKind.Local).AddTicks(1420),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 29, 12, 51, 46, 701, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "0B39A049-7277-4F28-9DDF-148907D7F987",
                column: "ConcurrencyStamp",
                value: "c460fbdb-6c08-4c98-87e2-6f55aaf3427a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: "3973E3F1-086C-4AFF-B484-431013385161",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "acb8a005-fa02-49e9-bfcf-942a37b6364a", "AQAAAAEAACcQAAAAEBlxG6tj2o2Drqk8T82G2QvMp2a8bxWuopWi8gTP7n9GQc0jtNpY8UgV2jNja/9FQw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 29, 11, 53, 37, 160, DateTimeKind.Local).AddTicks(7829));
        }
    }
}
