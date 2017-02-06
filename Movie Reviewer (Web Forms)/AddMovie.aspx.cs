using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_Reviewer__Web_Forms_
{
    public partial class AddMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.AllKeys.Contains("MovieTitle"))
            {
                using (var db = new ReviewContext())
                {
                    var movie = new Movie
                    {
                        MovieTitle = Request.Form["MovieTitle"],
                        Genre = Request.Form["Genre"],
                        ReleaseDate = DateTime.Parse(Request.Form["ReleaseDate"]),
                        IMDBLink = Request.Form["IMDBLink"],

                    };
                    db.Movie.Add(movie);
                    db.SaveChanges();
                }
            }
            Response.Redirect("MovieNew.aspx");
        }
    }
}