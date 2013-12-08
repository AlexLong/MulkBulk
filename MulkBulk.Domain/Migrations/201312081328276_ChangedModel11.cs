namespace MulkBulk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedModel11 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MulkUserProfiles", "RegistrationDate");
            /*
            DropColumn("dbo.MulkUserProfiles", "FirstName");
            DropColumn("dbo.MulkUserProfiles", "LastName");
            DropColumn("dbo.MulkUserProfiles", "Email");
            
            AddColumn("dbo.MulkUserProfiles", "Email", c => c.String(maxLength:128));
            AddColumn("dbo.MulkUserProfiles", "BirthDay", c => c.String());
            AddColumn("dbo.MulkUserProfiles", "FirstName", c => c.String(maxLength:128));
            AddColumn("dbo.MulkUserProfiles", "LastName", c => c.String(maxLength: 128));

            AddColumn("dbo.AspNetUsers", "RegistrationDate", c => c.DateTime());
             * */

        }
        
        public override void Down()
        {
        }
    }
}
