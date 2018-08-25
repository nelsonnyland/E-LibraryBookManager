namespace GroupSourceControlProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "IsAdmin");
        }
    }
}
