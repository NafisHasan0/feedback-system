namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updates : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.feedbacks", "userID", "dbo.users");
            DropIndex("dbo.feedbacks", new[] { "userID" });
            AlterColumn("dbo.feedbacks", "userID", c => c.Int());
            CreateIndex("dbo.feedbacks", "userID");
            AddForeignKey("dbo.feedbacks", "userID", "dbo.users", "userID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.feedbacks", "userID", "dbo.users");
            DropIndex("dbo.feedbacks", new[] { "userID" });
            AlterColumn("dbo.feedbacks", "userID", c => c.Int(nullable: false));
            CreateIndex("dbo.feedbacks", "userID");
            AddForeignKey("dbo.feedbacks", "userID", "dbo.users", "userID", cascadeDelete: true);
        }
    }
}
