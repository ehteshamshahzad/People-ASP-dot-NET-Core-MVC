using Microsoft.EntityFrameworkCore.Migrations;

namespace People.Migrations
{
    public partial class AddressModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Name_People_PersonID",
                table: "Name");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_People_PersonID",
                table: "PhoneNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumber",
                table: "PhoneNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Name",
                table: "Name");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "People");

            migrationBuilder.RenameTable(
                name: "PhoneNumber",
                newName: "PhoneNumbers");

            migrationBuilder.RenameTable(
                name: "Name",
                newName: "Names");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumber_PersonID",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_Name_PersonID",
                table: "Names",
                newName: "IX_Names_PersonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Names",
                table: "Names",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PersonAddress",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false),
                    AddressID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAddress", x => new { x.PersonID, x.AddressID });
                    table.ForeignKey(
                        name: "FK_PersonAddress_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonAddress_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_AddressID",
                table: "PersonAddress",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Names_People_PersonID",
                table: "Names",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_People_PersonID",
                table: "PhoneNumbers",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Names_People_PersonID",
                table: "Names");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_People_PersonID",
                table: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "PersonAddress");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Names",
                table: "Names");

            migrationBuilder.RenameTable(
                name: "PhoneNumbers",
                newName: "PhoneNumber");

            migrationBuilder.RenameTable(
                name: "Names",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_PersonID",
                table: "PhoneNumber",
                newName: "IX_PhoneNumber_PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_Names_PersonID",
                table: "Name",
                newName: "IX_Name_PersonID");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "People",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumber",
                table: "PhoneNumber",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Name",
                table: "Name",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Name_People_PersonID",
                table: "Name",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_People_PersonID",
                table: "PhoneNumber",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
