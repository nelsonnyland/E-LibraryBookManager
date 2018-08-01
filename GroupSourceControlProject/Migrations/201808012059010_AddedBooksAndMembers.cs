namespace GroupSourceControlProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBooksAndMembers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        PubDate = c.Int(nullable: false),
                        CheckedOut = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BookID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        CardNumber = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                    })
                .PrimaryKey(t => t.CardNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
            DropTable("dbo.Books");
        }
    }
}
