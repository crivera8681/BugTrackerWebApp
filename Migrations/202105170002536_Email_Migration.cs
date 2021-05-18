namespace BugTrackerWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Email_Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bugs", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Bugs", "UserAccount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bugs", "UserAccount", c => c.String());
            DropColumn("dbo.Bugs", "Email");
        }
    }
}
