namespace GroupSourceControlProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBStart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        ISBN = c.String(),
                        Title = c.String(),
                        Author = c.String(),
                        PubDate = c.Int(nullable: false),
                        CheckedOut = c.Boolean(nullable: false),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.BookID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        CardNumber = c.Int(nullable: false),
                        PIN = c.Int(nullable: false),
                        LastName = c.String(),
                        FirstName = c.String(),
                    })
                .PrimaryKey(t => t.MemberID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
            DropTable("dbo.Books");
        }
    }
}
