
using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace Movie_Reviewer__Web_Forms_
{
    public partial class EditMovie : System.Web.UI.Page
    {
        public Movie movieInstance;
        public List<Movie> Movies;

        protected void Page_Load(object sender, EventArgs e)
        {
            var movieId = int.Parse(Request.QueryString["id"]);
            using (var db = new ReviewContext())
            {
                Movies = db.Movie.ToList();
                movieInstance = db.Movie.First(x => x.Id == movieId);
                if (IsPostBack)
                {
                    movieInstance.MovieTitle = Request.Form["MovieTitle"];
                    movieInstance.ReleaseDate = DateTime.Parse(Request.Form["ReleaseDate"]);
                    movieInstance.IMDBLink = Request.Form["IMDBLink"];

                    db.Entry(movieInstance).State = EntityState.Modified;
                    db.SaveChanges();
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}