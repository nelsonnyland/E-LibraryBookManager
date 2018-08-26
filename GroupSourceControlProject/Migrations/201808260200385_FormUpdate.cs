namespace GroupSourceControlProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Member_MemberID", c => c.Int());
            CreateIndex("dbo.Books", "Member_MemberID");
            AddForeignKey("dbo.Books", "Member_MemberID", "dbo.Members", "MemberID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Member_MemberID", "dbo.Members");
            DropIndex("dbo.Books", new[] { "Member_MemberID" });
            DropColumn("dbo.Books", "Member_MemberID");
        }
    }
}
