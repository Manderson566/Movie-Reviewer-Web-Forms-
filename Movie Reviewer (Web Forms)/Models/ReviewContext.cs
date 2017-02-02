using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Movie_Reviewer__Web_Forms_
{
    public class ReviewContext : DbContext
    {
        public DbSet<Review> Review { get; set; }
        public DbSet<Movie> Movie { get; set; }
    }
}