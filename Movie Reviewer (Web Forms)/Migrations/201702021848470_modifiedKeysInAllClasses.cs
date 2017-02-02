namespace Movie_Reviewer__Web_Forms_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedKeysInAllClasses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Review_Id", "dbo.Reviews");
            DropIndex("dbo.Movies", new[] { "Review_Id" });
            AddColumn("dbo.Movies", "Genre", c => c.String());
            AddColumn("dbo.Movies", "IMDBLink", c => c.String());
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reviews", "ReviewerName", c => c.String());
            AddColumn("dbo.Reviews", "MovieRating", c => c.Int(nullable: false));
            AddColumn("dbo.Reviews", "AgeOfReviewer", c => c.Int(nullable: false));
            AddColumn("dbo.Reviews", "GenderofReviewr", c => c.String());
            AddColumn("dbo.Reviews", "OccupationOfReviewer", c => c.String());
            AddColumn("dbo.Reviews", "DateTimeOfReview", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reviews", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Reviews", "Movie_Id");
            AddForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies", "Id");
            DropColumn("dbo.Movies", "MovieDetail");
            DropColumn("dbo.Movies", "Review_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Review_Id", c => c.Int());
            AddColumn("dbo.Movies", "MovieDetail", c => c.String());
            DropForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "Movie_Id" });
            DropColumn("dbo.Reviews", "Movie_Id");
            DropColumn("dbo.Reviews", "DateTimeOfReview");
            DropColumn("dbo.Reviews", "OccupationOfReviewer");
            DropColumn("dbo.Reviews", "GenderofReviewr");
            DropColumn("dbo.Reviews", "AgeOfReviewer");
            DropColumn("dbo.Reviews", "MovieRating");
            DropColumn("dbo.Reviews", "ReviewerName");
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "IMDBLink");
            DropColumn("dbo.Movies", "Genre");
            CreateIndex("dbo.Movies", "Review_Id");
            AddForeignKey("dbo.Movies", "Review_Id", "dbo.Reviews", "Id");
        }
    }
}
