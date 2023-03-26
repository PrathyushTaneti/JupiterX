using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JupiterX.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SWIFTCode = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
