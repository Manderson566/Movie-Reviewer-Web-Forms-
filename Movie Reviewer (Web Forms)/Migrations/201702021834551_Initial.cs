namespace Movie_Reviewer__Web_Forms_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieTitle = c.String(),
                        MovieDetail = c.String(),
                        Review_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reviews", t => t.Review_Id)
                .Index(t => t.Review_Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieReview = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Review_Id", "dbo.Reviews");
            DropIndex("dbo.Movies", new[] { "Review_Id" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Movies");
        }
    }
}
