namespace MulkBulk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MessageContent = c.String(),
                        SenderID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.SenderID, cascadeDelete: true)
                .Index(t => t.SenderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "SenderID", "dbo.Users");
            DropIndex("dbo.Messages", new[] { "SenderID" });
            DropTable("dbo.Messages");
        }
    }
}
