using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Reviewer__Web_Forms_
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string Genre { get; set; }
        public string IMDBLink { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}