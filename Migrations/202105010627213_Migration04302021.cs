namespace BugTrackerWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration04302021 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bugs", "UserAccount", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bugs", "UserAccount");
        }
    }
}
