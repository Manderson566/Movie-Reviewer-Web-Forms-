namespace Movie_Reviewer__Web_Forms_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedMoviecsDateTimeToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
        }
    }
}
