namespace Movie_Reviewer__Web_Forms_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieTitleToReviewcs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "MovieTitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "MovieTitle");
        }
    }
}
