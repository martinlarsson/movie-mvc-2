using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieMVC2.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Title cannot be blank.")]
        [StringLength(100, ErrorMessage = "The title cannot be longer than 100 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You must enter a rank.")]
        [Range(1,5, ErrorMessage = "Rank must be between 1 and 5.")]
        public int Rank { get; set; }
        [Required(ErrorMessage = "Genre cannot be blank.")]
        [StringLength(50, ErrorMessage = "Genre cannot be longer than 50 characters.")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "You must enter a release date.")]
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}