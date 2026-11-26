using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trainer_companion.Migrations;

/// <inheritdoc />
public partial class _20261126143416_InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Students",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Students", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Notes",
            columns: table => new
            {
                NoteId = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                NoteContent = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Notes", x => x.NoteId);
                table.ForeignKey(
                    name: "FK_Notes_Students_StudentId",
                    column: x => x.StudentId,
                    principalTable: "Students",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Notes_StudentId",
            table: "Notes",
            column: "StudentId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Notes");

        migrationBuilder.DropTable(
            name: "Students");
    }
}
