using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SS.DataAccess.Migrations
{
    public partial class add_productImage_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 11, 53, 37, 149, DateTimeKind.Local).AddTicks(4721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 26, 22, 46, 41, 276, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 11, 53, 37, 144, DateTimeKind.Local).AddTicks(1420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 26, 22, 46, 41, 269, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 500, nullable: false),
                    Caption = table.Column<string>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false),
                    DeateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 22, 46, 41, 276, DateTimeKind.Local).AddTicks(5859),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 29, 11, 53, 37, 149, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 22, 46, 41, 269, DateTimeKind.Local).AddTicks(1351),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 29, 11, 53, 37, 144, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "0B39A049-7277-4F28-9DDF-148907D7F987",
                column: "ConcurrencyStamp",
                value: "e184cd95-6235-496f-9dbb-f7a8018fd53d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: "3973E3F1-086C-4AFF-B484-431013385161",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19471fe7-df3b-402b-87a1-da4585b76839", "AQAAAAEAACcQAAAAEDv/6uP6b52f8PejhuiZJCrdweZk7Lsl6RnpcHzoXhDAElyEzBpwb6F0yHDezjzSaA==" });

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
                value: new DateTime(2020, 10, 26, 22, 46, 41, 288, DateTimeKind.Local).AddTicks(1159));
        }
    }
}
