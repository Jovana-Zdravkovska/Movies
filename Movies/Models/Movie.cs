using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        [Required]
        [Display(Name = "Movie Name")]
        public String Name { get; set; }
        public String Picture { get; set; }
        [Display(Name = "Relese Date")]
        public String ReleseDate { get; set; }

        [Range(0, 5)]
        public float Rating { get; set; }
        [Display(Name = "IMDB Link")]
        public String IMDBLink { get; set; }
        [Display(Name = "People")]
        public String PeopleWorkingOnMovie { get; set; }
        [Display(Name = "Genres")]
        public String GenresInMovie { get; set; }
        public List<Person> People { get; set; }
        public List<Genre> Genres { get; set; }
        public Movie()
        {
            People = new List<Person>();
            Genres = new List<Genre>();
        }
    }
}