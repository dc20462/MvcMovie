using System;
using Microsoft.EntityFrameworkCore.Migrations;
// 시간별 만들어진 데이터베이스

namespace MvcMovie.Migrations
{
    public partial class InitialCreate : Migration
    {
        // Movie 테이블을 만들고 Id를 기본 키로 구성
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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

        // Up 마이그레이션에 의해 변경된 스키마를 되돌림
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
