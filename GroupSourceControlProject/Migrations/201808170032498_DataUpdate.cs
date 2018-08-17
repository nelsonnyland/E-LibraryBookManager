namespace GroupSourceControlProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "ISBN", c => c.String());
            AddColumn("dbo.Books", "Category", c => c.String());
            AddColumn("dbo.Members", "PIN", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "PIN");
            DropColumn("dbo.Books", "Category");
            DropColumn("dbo.Books", "ISBN");
        }
    }
}
