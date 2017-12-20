using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMVC2.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Rank { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}