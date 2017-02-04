<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Movie_Reviewer__Web_Forms_.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movie Reviews</title>
    <link href="Content/bootstrap.css"rel="stylesheet" type="text/css" />
</head>
<body>
    <div class ="container">
        <h1>Movie Reviews</h1>
        <form runat="server" action="Add.aspx" method="post">
            <div class="form-group">
                <input type="text" class="form-control" name="MovieReview" placeholder ="Write Your Review" /> 
                <input type="text" class="form-control" name="MovieRating" placeholder="Rate The Movie 1 to 5" />
                <input type="text" class="form-control" name="ReviewerName" placeholder="Your Name" />
                <input type="text" class="form-control" name="GenderofReviewer" placeholder="Your Gender" />
                <input type="text" class="form-control" name="OccupationOfReviewer" placeholder="Your Gender" />
                
            </div>
            <input type="button" class ="btn btn-default" value="Add" />
            </form>
        <select class ="DropDown">
            <%foreach (var movie in Movies)
                {%>
                 <option value="<%=movie.MovieTitle %>"><%= movie.MovieTitle %></option>
            
                <% } %>
        </select>
        <table class ="table">
            <thead>
                <tr>
                 <td>Movie</td>
                 <td>MovieReview</td>
                 <td>MovieRaiting</td>
                 <td>ReviewedBy</td>
                 <td>ReviewerAge</td>
                 <td>ReviewerGender</td>
                 <td>ReviewerGender</td>
                 <td>ReviewCreated</td>
                </tr>
            </thead>
            <tbody>
                <%foreach (var Review in Reviews)
                    {%>
               
                <tr>
                    <td><%=Review.MovieId %></td>
                    <td><%=Review.MovieRating %></td>
                    <td><%=Review.AgeOfReviewer %></td>
                    <td><%=Review.GenderofReviewer %></td>
                    <td><%=Review.OccupationOfReviewer %></td>
                    <td><%=Review.GenderofReviewer %></td>
                    <td><%=Review.DateTimeOfReview %></td>
                </tr>                        
                  <% } %>
            </tbody>
        </table>   
    </div>
</body>
</html>
