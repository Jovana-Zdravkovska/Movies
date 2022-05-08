using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        [Display(Name = "Genre Name")]
        public String Name { get; set; }
    }
}