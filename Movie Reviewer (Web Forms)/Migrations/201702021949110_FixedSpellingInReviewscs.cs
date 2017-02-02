namespace Movie_Reviewer__Web_Forms_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedSpellingInReviewscs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "GenderofReviewer", c => c.String());
            DropColumn("dbo.Reviews", "GenderofReviewr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "GenderofReviewr", c => c.String());
            DropColumn("dbo.Reviews", "GenderofReviewer");
        }
    }
}
