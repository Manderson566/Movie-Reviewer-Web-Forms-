<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieNew.aspx.cs" Inherits="Movie_Reviewer__Web_Forms_.MovieEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MovieNew</title>
    <link href="Content/bootstrap.css"rel="stylesheet" type="text/css" />
</head>
<body>
       <div class ="container">
        <h1>Add A Movie</h1>
        <form runat="server" action="AddMovie.aspx" method="post">
            <div class="form-group">
                <input type="text" class="form-control" name="MovieTitle" placeholder ="Title of Movie" /> 
                <input type="text" class="form-control" name="Genre" placeholder="Genre of Movie" />
                <input type="text" class="form-control" name="IMDBLink" placeholder="IMDB Link for Movie" />
                <input type="text" class="form-control" name="ReleaseDate" placeholder="Release Date of Movie" />                 
            </div>
            <div class="container">
            <input type="submit" class ="btn btn-default" value="Add" />
            <a href="Default.aspx" class="btn btn-default" role="button">Add Review</a>
            </div>
            </form>
    </div>
</body>
</html>
