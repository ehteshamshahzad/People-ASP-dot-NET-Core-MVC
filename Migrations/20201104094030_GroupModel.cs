using Microsoft.EntityFrameworkCore.Migrations;

namespace People.Migrations
{
    public partial class GroupModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PersonGroup",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false),
                    GroupID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonGroup", x => new { x.PersonID, x.GroupID });
                    table.ForeignKey(
                        name: "FK_PersonGroup_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonGroup_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonGroup_GroupID",
                table: "PersonGroup",
                column: "GroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonGroup");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
