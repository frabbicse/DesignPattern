using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesignPatternConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsAccountC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseOrganizationInstitutionC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployerC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealStateAgencyC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredTraingOrgTROC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RentalAgencyC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataModels");
        }
    }
}
