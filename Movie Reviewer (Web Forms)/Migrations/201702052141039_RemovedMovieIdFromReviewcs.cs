namespace Movie_Reviewer__Web_Forms_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedMovieIdFromReviewcs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "MovieId", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "MovieId" });
            RenameColumn(table: "dbo.Reviews", name: "MovieId", newName: "Movie_Id");
            AlterColumn("dbo.Reviews", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Reviews", "Movie_Id");
            AddForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "Movie_Id" });
            AlterColumn("dbo.Reviews", "Movie_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Reviews", name: "Movie_Id", newName: "MovieId");
            CreateIndex("dbo.Reviews", "MovieId");
            AddForeignKey("dbo.Reviews", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
        }
    }
}
