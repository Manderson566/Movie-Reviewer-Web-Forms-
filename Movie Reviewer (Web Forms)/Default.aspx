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
