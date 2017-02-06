namespace Movie_Reviewer__Web_Forms_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedMovieIdAddedMovieTitle : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "MovieId", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "MovieId" });
            RenameColumn(table: "dbo.Reviews", name: "MovieId", newName: "Movie_Id");
            AddColumn("dbo.Reviews", "MovieTitle_Id", c => c.Int());
            AlterColumn("dbo.Reviews", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Reviews", "Movie_Id");
            CreateIndex("dbo.Reviews", "MovieTitle_Id");
            AddForeignKey("dbo.Reviews", "MovieTitle_Id", "dbo.Movies", "Id");
            AddForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies", "Id");
            DropColumn("dbo.Reviews", "MovieTitle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "MovieTitle", c => c.String());
            DropForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Reviews", "MovieTitle_Id", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "MovieTitle_Id" });
            DropIndex("dbo.Reviews", new[] { "Movie_Id" });
            AlterColumn("dbo.Reviews", "Movie_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Reviews", "MovieTitle_Id");
            RenameColumn(table: "dbo.Reviews", name: "Movie_Id", newName: "MovieId");
            CreateIndex("dbo.Reviews", "MovieId");
            AddForeignKey("dbo.Reviews", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
        }
    }
}
