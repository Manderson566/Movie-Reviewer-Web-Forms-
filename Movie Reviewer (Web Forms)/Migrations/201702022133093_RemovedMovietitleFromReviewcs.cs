namespace Movie_Reviewer__Web_Forms_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedMovietitleFromReviewcs : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reviews", "MovieTitle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "MovieTitle", c => c.String());
        }
    }
}
