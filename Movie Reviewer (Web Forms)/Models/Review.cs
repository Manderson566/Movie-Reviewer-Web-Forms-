using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Reviewer__Web_Forms_
{
    public class Review
    {
        public int Id { get; set; }
        public string MovieReview { get; set; }
        public string ReviewerName { get; set; }
        public int MovieRating { get; set; }
        public int AgeOfReviewer { get; set; }
        public string GenderofReviewer { get; set; }
        public string OccupationOfReviewer { get; set; }
        public DateTime DateTimeOfReview { get; set; }
        public virtual Movie Movie { get; set; }

    }
}