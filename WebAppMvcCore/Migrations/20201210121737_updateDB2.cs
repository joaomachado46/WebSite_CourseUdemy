using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMvcCore.Migrations
{
    public partial class updateDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecords_Sellers_SellerIdId",
                table: "SalesRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Department_DepartmentIdId",
                table: "Sellers");

            migrationBuilder.RenameColumn(
                name: "DepartmentIdId",
                table: "Sellers",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Sellers_DepartmentIdId",
                table: "Sellers",
                newName: "IX_Sellers_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "SellerIdId",
                table: "SalesRecords",
                newName: "SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecords_SellerIdId",
                table: "SalesRecords",
                newName: "IX_SalesRecords_SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecords_Sellers_SellerId",
                table: "SalesRecords",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Department_DepartmentId",
                table: "Sellers",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecords_Sellers_SellerId",
                table: "SalesRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Department_DepartmentId",
                table: "Sellers");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Sellers",
                newName: "DepartmentIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Sellers_DepartmentId",
                table: "Sellers",
                newName: "IX_Sellers_DepartmentIdId");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "SalesRecords",
                newName: "SellerIdId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecords_SellerId",
                table: "SalesRecords",
                newName: "IX_SalesRecords_SellerIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecords_Sellers_SellerIdId",
                table: "SalesRecords",
                column: "SellerIdId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Department_DepartmentIdId",
                table: "Sellers",
                column: "DepartmentIdId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
