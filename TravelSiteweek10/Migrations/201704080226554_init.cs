namespace TravelSiteweek10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        AccomodationType = c.String(),
                        LocationName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        TookChildren = c.Boolean(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Users", new[] { "CategoryID" });
            DropTable("dbo.Users");
            DropTable("dbo.Categories");
        }
    }
}
