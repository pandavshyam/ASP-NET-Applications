using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieProjectWithCodeFirstApproach.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public float Price { get; set; }
    }
}