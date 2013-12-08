namespace MulkBulk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MessageContent = c.String(),
                        ReceiverID = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MulkUserProfiles", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.MulkUserProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserMessages", "AuthorId", "dbo.MulkUserProfiles");
            DropIndex("dbo.UserMessages", new[] { "AuthorId" });
            DropTable("dbo.MulkUserProfiles");
            DropTable("dbo.UserMessages");
        }
    }
}
