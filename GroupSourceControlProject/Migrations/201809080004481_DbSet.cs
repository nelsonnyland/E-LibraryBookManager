namespace GroupSourceControlProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ISBN = c.String(nullable: false, maxLength: 8),
                        Title = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        PubDate = c.Int(nullable: false),
                        Category = c.String(nullable: false),
                        CheckedOutBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ISBN);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberID = c.String(nullable: false, maxLength: 9),
                        Username = c.String(nullable: false),
                        PIN = c.Int(nullable: false),
                        LastName = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
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
