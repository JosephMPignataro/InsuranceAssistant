using Microsoft.EntityFrameworkCore.Migrations;

namespace InsuranceAssistant.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    ProvidingCompany = table.Column<string>(nullable: true),
                    CaseManager = table.Column<string>(nullable: true),
                    ClientAge = table.Column<string>(nullable: true),
                    FaceAmmount = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Agent = table.Column<string>(nullable: true),
                    CompletionDate = table.Column<string>(nullable: true),
                    ProductType = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Case");
        }
    }
}
