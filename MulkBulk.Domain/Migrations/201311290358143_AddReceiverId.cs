namespace MulkBulk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReceiverId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "ReceiverID", c => c.Int(nullable: false));
        }
        public override void Down()
        {
            DropColumn("dbo.Messages", "ReceiverID");
        }
    }
}
