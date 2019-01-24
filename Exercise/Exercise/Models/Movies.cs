using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Exercise.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        [NotMapped]
        public List<Movies> Movie { set; get; }
    }
}