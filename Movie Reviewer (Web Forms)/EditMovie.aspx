<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditMovie.aspx.cs" Inherits="Movie_Reviewer__Web_Forms_.EditMovie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Movie</title>
    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <div class="form-group">
                <input class="form-control" type="text" value="<%=movieInstance.MovieTitle %>" name="Movie Title" />
                <input class="form-control" type="text" value="<%=movieInstance.ReleaseDate %>" name="Release Date" />
                <input class="form-control" type="text" value="<%=movieInstance.IMDBLink %>" name="IMDB Link" />
                <p>
                    Created: <%=movieInstance.Created %>
                </p>
                <input type="submit" class="btn btn-success" />
            </div>
        </form>
    </div>
</body>
</html>
