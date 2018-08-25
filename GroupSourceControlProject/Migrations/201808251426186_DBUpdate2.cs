namespace GroupSourceControlProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Username", c => c.String());
            DropColumn("dbo.Members", "CardNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "CardNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Members", "Username");
        }
    }
}
