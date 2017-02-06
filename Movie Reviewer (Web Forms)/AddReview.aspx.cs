using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_Reviewer__Web_Forms_
{
    public partial class Add : System.Web.UI.Page
    {
        public static string MovieInstance;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.AllKeys.Contains("MovieReview"))
            {
                using (var db = new ReviewContext())
                {   
                    var review = new Review
                    {
                        MovieReview = Request.Form["MovieReview"],
                        MovieRating = Request.Form["MovieRating"].Count(),
                        ReviewerName = Request.Form["ReviewerName"],
                        GenderofReviewer = Request.Form["GenderofReviewer"],
                        OccupationOfReviewer = Request.Form["OccupationOfReviewer"],
                        AgeOfReviewer = Request.Form["AgeOfReviewer"].Count(),
                        DateTimeOfReview = DateTime.Now,
                        MovieId = 1
                    };
                    db.Review.Add(review);
                    db.SaveChanges();
                }                
            }
            Response.Redirect("Default.aspx");
        }
    }
}
