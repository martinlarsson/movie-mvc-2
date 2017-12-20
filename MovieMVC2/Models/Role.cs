using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMVC2.Models
{
    public class Role
    {
        public int ID { get; set; }
        public string Character { get; set; }
        public int? ActorID { get; set; }
        public int? MovieID { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Actor Actor { get; set; }
    }
}