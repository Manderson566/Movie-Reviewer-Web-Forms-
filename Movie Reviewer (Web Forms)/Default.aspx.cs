using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_Reviewer__Web_Forms_
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Review> Reviews;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new ReviewContext())
            {
                Reviews = db.Review.ToList();
            }
        }
    }
}