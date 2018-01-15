using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieMVC2.Models
{
    public class Actor
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name cannot be blank")]
        [StringLength(100, ErrorMessage = "Name cannot be more than 100 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must enter a birth date")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Bio cannot be blank.")]
        public string Bio { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}