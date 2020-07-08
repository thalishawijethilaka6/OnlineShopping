using Microsoft.EntityFrameworkCore.Migrations;

namespace Virtusa.Assigment.ShoppingCart.Data.Migrations
{
    public partial class InitialCreateuu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productEntities_Categories_CategoryEntityId",
                table: "productEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productEntities",
                table: "productEntities");

            migrationBuilder.RenameTable(
                name: "productEntities",
                newName: "products");

            migrationBuilder.RenameIndex(
                name: "IX_productEntities_CategoryEntityId",
                table: "products",
                newName: "IX_products_CategoryEntityId");

            migrationBuilder.AddColumn<int>(
                name: "CategryId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_CategoryEntityId",
                table: "products",
                column: "CategoryEntityId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_CategoryEntityId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropColumn(
                name: "CategryId",
                table: "products");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "productEntities");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryEntityId",
                table: "productEntities",
                newName: "IX_productEntities_CategoryEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productEntities",
                table: "productEntities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productEntities_Categories_CategoryEntityId",
                table: "productEntities",
                column: "CategoryEntityId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
