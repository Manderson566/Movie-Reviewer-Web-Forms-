namespace Movie_Reviewer__Web_Forms_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieIdBackinReviewcs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "Movie_Id" });
            RenameColumn(table: "dbo.Reviews", name: "Movie_Id", newName: "MovieId");
            AlterColumn("dbo.Reviews", "MovieId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "MovieId");
            AddForeignKey("dbo.Reviews", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "MovieId", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "MovieId" });
            AlterColumn("dbo.Reviews", "MovieId", c => c.Int());
            RenameColumn(table: "dbo.Reviews", name: "MovieId", newName: "Movie_Id");
            CreateIndex("dbo.Reviews", "Movie_Id");
            AddForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies", "Id");
        }
    }
}
