using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieMVC2.Models
{
    public class Role
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Character must be blank.")]
        [StringLength(100, ErrorMessage = "Character cannot be longer than 100 characters.")]
        public string Character { get; set; }
        public int? ActorID { get; set; }
        public int? MovieID { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Actor Actor { get; set; }
    }
}