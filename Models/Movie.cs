using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // 2022-01-17

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        
        [Display(Name = "Release Date")]   // 필드의 이름으로 표시할 내용을 지정 // 2022-01-17
        [DataType(DataType.Date)] // 필드에 저장된 시간정보가 표시되지 않게 날짜 데이터 형식을 지정함
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")] // Price 올바른 단위 맵핑을 위해 주석 추가 // 2022-01-17
        public decimal Price { get; set; }
    }
}