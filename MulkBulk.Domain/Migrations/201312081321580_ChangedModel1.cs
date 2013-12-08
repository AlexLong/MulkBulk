namespace MulkBulk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedModel1 : DbMigration
    {
        public override void Up()
        {

           // DropColumn("dbo.MulkUserProfiles", "BirthDay");

          AddColumn("dbo.MulkUserProfiles","BirthDay", c => c.DateTime(nullable: true));

           
        }
        
        public override void Down()
        {
        }
    }
}
