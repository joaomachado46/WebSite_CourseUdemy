using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMvcCore.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecords_Sellers_SellerId",
                table: "SalesRecords");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "SalesRecords",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecords_Sellers_SellerId",
                table: "SalesRecords",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecords_Sellers_SellerId",
                table: "SalesRecords");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "SalesRecords",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecords_Sellers_SellerId",
                table: "SalesRecords",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
