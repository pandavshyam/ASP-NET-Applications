using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieProjectWithCodeFirstApproach.Models
{
    public class MovieProjectEntities : DbContext
    {
        public MovieProjectEntities() : base("name=MoviesProjectEntities")
        {

        }

        public virtual DbSet<Movie> Movies { get; set; }
    }
}