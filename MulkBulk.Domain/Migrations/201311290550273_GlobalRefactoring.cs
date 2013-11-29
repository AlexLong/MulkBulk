namespace MulkBulk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GlobalRefactoring : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "SenderID", "dbo.Users");
            DropIndex("dbo.Messages", new[] { "SenderID" });
            CreateTable(
                "dbo.UserMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MessageContent = c.String(),
                        ReceiverID = c.Int(nullable: false),
                        SenderID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserEntities", t => t.SenderID, cascadeDelete: true)
                .Index(t => t.SenderID);
            
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            DropTable("dbo.Messages");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MessageContent = c.String(),
                        ReceiverID = c.Int(nullable: false),
                        SenderID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.UserMessages", "SenderID", "dbo.UserEntities");
            DropIndex("dbo.UserMessages", new[] { "SenderID" });
            DropTable("dbo.UserEntities");
            DropTable("dbo.UserMessages");
            CreateIndex("dbo.Messages", "SenderID");
            AddForeignKey("dbo.Messages", "SenderID", "dbo.Users", "UserID", cascadeDelete: true);
        }
    }
}
