using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KitchenId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Kitchen",
                columns: table => new
                {
                    KitchenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitchen", x => x.KitchenId);
                    table.ForeignKey(
                        name: "FK_Kitchen_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatesofMenu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dishes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Portions = table.Column<int>(type: "int", nullable: false),
                    KitchenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menu_Kitchen_KitchenId",
                        column: x => x.KitchenId,
                        principalTable: "Kitchen",
                        principalColumn: "KitchenId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_KitchenId",
                table: "Employees",
                column: "KitchenId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitchen_GroupId",
                table: "Kitchen",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_KitchenId",
                table: "Menu",
                column: "KitchenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Kitchen_KitchenId",
                table: "Employees",
                column: "KitchenId",
                principalTable: "Kitchen",
                principalColumn: "KitchenId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Kitchen_KitchenId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Kitchen");

            migrationBuilder.DropIndex(
                name: "IX_Employees_KitchenId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "KitchenId",
                table: "Employees");
        }
    }
}
