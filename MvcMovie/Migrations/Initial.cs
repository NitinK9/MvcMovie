using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class Initial : Migration
    {
        public Initial()
        {
        }

        protected override void Up([NotNullAttribute] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                        name: "Movie",
                        columns: table => new
                        {
                            Id = table.Column<int>(nullable: false)
                                .Annotation("SqlServer:ValueGenerationStrategy",
                                             SqlServerValueGenerationStrategy.IdentityColumn),
                            Title = table.Column<string>(nullable: true),
                            ReleaseDate = table.Column<DateTime>(nullable: false),
                            Genre = table.Column<string>(nullable: true),
                            Price = table.Column<decimal>(nullable: false)
                        },
                        constraints: table =>
                        {
                            table.PrimaryKey("PK_Movie", x => x.Id);
                        });
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
