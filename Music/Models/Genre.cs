using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Music.Models
{
    public class Genre
    {
        //[Display(Name = "Genre")]
        //[Required, StringLength(20)]
        public int GenreID { get; set; }
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
    }
}