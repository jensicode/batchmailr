using Microsoft.EntityFrameworkCore.Migrations;

namespace batchmailr.Migrations
{
    public partial class AddSystemTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailSubject = table.Column<string>(nullable: true),
                    EmailHtmlContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailId);
                });

            migrationBuilder.CreateTable(
                name: "LayoutTemplates",
                columns: table => new
                {
                    LayoutTemplateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LayoutTemplateName = table.Column<string>(nullable: true),
                    LayoutTemplateContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LayoutTemplates", x => x.LayoutTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "RecipientLists",
                columns: table => new
                {
                    RecipientListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipientListName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipientLists", x => x.RecipientListId);
                });

            migrationBuilder.CreateTable(
                name: "TextTemplates",
                columns: table => new
                {
                    TextTemplateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextTemplateName = table.Column<string>(nullable: true),
                    TextTemplateContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextTemplates", x => x.TextTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "Recipients",
                columns: table => new
                {
                    RecipientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipientMailAddress = table.Column<string>(nullable: true),
                    RecipientListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipients", x => x.RecipientId);
                    table.ForeignKey(
                        name: "FK_Recipients_RecipientLists_RecipientListId",
                        column: x => x.RecipientListId,
                        principalTable: "RecipientLists",
                        principalColumn: "RecipientListId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipients_RecipientListId",
                table: "Recipients",
                column: "RecipientListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "LayoutTemplates");

            migrationBuilder.DropTable(
                name: "Recipients");

            migrationBuilder.DropTable(
                name: "TextTemplates");

            migrationBuilder.DropTable(
                name: "RecipientLists");
        }
    }
}
