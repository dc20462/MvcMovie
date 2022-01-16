using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        // 엔터티 집합에 대해 DbSet<Movie> 속성을 만듭니다.
        // Entity Framework 용어에서 엔터티 집합은 일반적으로 데이터베이스 테이블에 해당합니다.
        // 엔터티는 테이블의 행에 해당합니다.
        public DbSet<Movie> Movie { get; set; }
    }
}