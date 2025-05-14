namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.feedbackResponses",
                c => new
                    {
                        feedbackResponseID = c.Int(nullable: false, identity: true),
                        feedbackID = c.Int(nullable: false),
                        response = c.String(),
                        IsResolved = c.String(),
                        DateSubmitted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.feedbackResponseID)
                .ForeignKey("dbo.feedbacks", t => t.feedbackID, cascadeDelete: true)
                .Index(t => t.feedbackID);
            
            CreateTable(
                "dbo.feedbacks",
                c => new
                    {
                        feedbackID = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        title = c.String(),
                        description = c.String(),
                        Category = c.String(),
                        IsAnonymous = c.String(),
                        DateSubmitted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.feedbackID)
                .ForeignKey("dbo.users", t => t.userID, cascadeDelete: true)
                .Index(t => t.userID);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        role = c.String(),
                    })
                .PrimaryKey(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.feedbackResponses", "feedbackID", "dbo.feedbacks");
            DropForeignKey("dbo.feedbacks", "userID", "dbo.users");
            DropIndex("dbo.feedbacks", new[] { "userID" });
            DropIndex("dbo.feedbackResponses", new[] { "feedbackID" });
            DropTable("dbo.users");
            DropTable("dbo.feedbacks");
            DropTable("dbo.feedbackResponses");
        }
    }
}
