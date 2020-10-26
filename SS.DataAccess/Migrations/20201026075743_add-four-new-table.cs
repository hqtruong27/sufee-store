using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SS.DataAccess.Migrations
{
    public partial class addfournewtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeatCreated",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 14, 57, 42, 825, DateTimeKind.Local).AddTicks(6391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 26, 10, 57, 27, 847, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 14, 57, 42, 817, DateTimeKind.Local).AddTicks(3648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 26, 10, 57, 27, 839, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.CreateTable(
                name: "NewsCatalogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCatalogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(nullable: false, defaultValue: 3),
                    CountView = table.Column<int>(nullable: false, defaultValue: 0),
                    NewsCatalogId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_NewsCatalogs_NewsCatalogId",
                        column: x => x.NewsCatalogId,
                        principalTable: "NewsCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NewsCatalogTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(maxLength: 200, nullable: true),
                    SeoAlias = table.Column<string>(maxLength: 250, nullable: false),
                    NewsCatalogId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCatalogTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsCatalogTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewsCatalogTranslations_NewsCatalogs_NewsCatalogId",
                        column: x => x.NewsCatalogId,
                        principalTable: "NewsCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 300, nullable: false),
                    Content = table.Column<string>(nullable: false),
                    NewsId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewsTranslations_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_NewsCatalogId",
                table: "News",
                column: "NewsCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsCatalogTranslations_LanguageId",
                table: "NewsCatalogTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsCatalogTranslations_NewsCatalogId",
                table: "NewsCatalogTranslations",
                column: "NewsCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsTranslations_LanguageId",
                table: "NewsTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsTranslations_NewsId",
                table: "NewsTranslations",
                column: "NewsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsCatalogTranslations");

            migrationBuilder.DropTable(
                name: "NewsTranslations");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "NewsCatalogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeatCreated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 10, 57, 27, 847, DateTimeKind.Local).AddTicks(5788),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 26, 14, 57, 42, 825, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 26, 10, 57, 27, 839, DateTimeKind.Local).AddTicks(1219),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 26, 14, 57, 42, 817, DateTimeKind.Local).AddTicks(3648));
        }
    }
}
