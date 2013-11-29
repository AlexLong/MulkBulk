namespace MulkBulk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GlobalRefactoring1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserMessages", "SenderID", "dbo.UserEntities");
            DropForeignKey("dbo.UserMessages", "SenderID", "dbo.UserEntities");
            DropIndex("dbo.UserMessages", new[] { "SenderID" });
            DropIndex("dbo.UserMessages", new[] { "SenderID" });
            RenameColumn(table: "dbo.UserMessages", name: "SenderID", newName: "UserEntity_UserID");
            AlterColumn("dbo.UserMessages", "UserEntity_UserID", c => c.Int());
            CreateIndex("dbo.UserMessages", "ReceiverID");
            CreateIndex("dbo.UserMessages", "UserEntity_UserID");
            CreateIndex("dbo.UserMessages", "SenderID");
            AddForeignKey("dbo.UserMessages", "ReceiverID", "dbo.UserEntities", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.UserMessages", "UserEntity_UserID", "dbo.UserEntities", "UserID");
            AddForeignKey("dbo.UserMessages", "SenderID", "dbo.UserEntities", "UserID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserMessages", "SenderID", "dbo.UserEntities");
            DropForeignKey("dbo.UserMessages", "UserEntity_UserID", "dbo.UserEntities");
            DropForeignKey("dbo.UserMessages", "ReceiverID", "dbo.UserEntities");
            DropIndex("dbo.UserMessages", new[] { "SenderID" });
            DropIndex("dbo.UserMessages", new[] { "UserEntity_UserID" });
            DropIndex("dbo.UserMessages", new[] { "ReceiverID" });
            AlterColumn("dbo.UserMessages", "UserEntity_UserID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.UserMessages", name: "UserEntity_UserID", newName: "SenderID");
            CreateIndex("dbo.UserMessages", "SenderID");
            CreateIndex("dbo.UserMessages", "SenderID");
            AddForeignKey("dbo.UserMessages", "SenderID", "dbo.UserEntities", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.UserMessages", "SenderID", "dbo.UserEntities", "UserID", cascadeDelete: true);
        }
    }
}
