using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amado.Migrations
{
    /// <inheritdoc />
    public partial class version2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Cart_CartModelCartID",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "User",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "CartModelCartID",
                table: "Order",
                newName: "CartID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CartModelCartID",
                table: "Order",
                newName: "IX_Order_CartID");

            migrationBuilder.AlterColumn<double>(
                name: "Rate",
                table: "Item",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Brand",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Image",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Cart_CartID",
                table: "Order",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "CartID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Cart_CartID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Image");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "User",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CartID",
                table: "Order",
                newName: "CartModelCartID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CartID",
                table: "Order",
                newName: "IX_Order_CartModelCartID");

            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "Item",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Cart_CartModelCartID",
                table: "Order",
                column: "CartModelCartID",
                principalTable: "Cart",
                principalColumn: "CartID");
        }
    }
}
