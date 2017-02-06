namespace Movie_Reviewer__Web_Forms_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMovieTitleTostring : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "MovieTitle_Id", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "MovieTitle_Id" });
            AddColumn("dbo.Reviews", "MovieTitle", c => c.String());
            DropColumn("dbo.Reviews", "MovieTitle_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "MovieTitle_Id", c => c.Int());
            DropColumn("dbo.Reviews", "MovieTitle");
            CreateIndex("dbo.Reviews", "MovieTitle_Id");
            AddForeignKey("dbo.Reviews", "MovieTitle_Id", "dbo.Movies", "Id");
        }
    }
}
