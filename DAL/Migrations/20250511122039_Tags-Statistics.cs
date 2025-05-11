using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class TagsStatistics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Tags",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Tags",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "StatisticsTask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompleteTask = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: false),
                    ProjectId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticsTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatisticsTask_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatisticsTask_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatisticsUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompleteTask = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: false),
                    ProjectId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticsUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatisticsUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatisticsUser_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatisticsUser_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_CompanyId",
                table: "Tags",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StatisticsTask_CompanyId",
                table: "StatisticsTask",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StatisticsTask_ProjectId",
                table: "StatisticsTask",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_StatisticsUser_CompanyId",
                table: "StatisticsUser",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StatisticsUser_ProjectId",
                table: "StatisticsUser",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_StatisticsUser_UserId",
                table: "StatisticsUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Companies_CompanyId",
                table: "Tags",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Companies_CompanyId",
                table: "Tags");

            migrationBuilder.DropTable(
                name: "StatisticsTask");

            migrationBuilder.DropTable(
                name: "StatisticsUser");

            migrationBuilder.DropIndex(
                name: "IX_Tags_CompanyId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Tags");
        }
    }
}
