namespace WatchAndShare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContentsv11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdID = c.Int(nullable: false, identity: true),
                        AdName = c.String(),
                        AdGmail = c.String(),
                    })
                .PrimaryKey(t => t.AdID);
            
            CreateTable(
                "dbo.Animes",
                c => new
                    {
                        AID = c.Int(nullable: false, identity: true),
                        AName = c.String(),
                        Description = c.String(),
                        CreatedDT = c.DateTime(nullable: false),
                        Category_CatID = c.Int(),
                    })
                .PrimaryKey(t => t.AID)
                .ForeignKey("dbo.Categories", t => t.Category_CatID)
                .Index(t => t.Category_CatID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CatID = c.Int(nullable: false, identity: true),
                        CatName = c.String(),
                    })
                .PrimaryKey(t => t.CatID);
            
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        CiID = c.Int(nullable: false, identity: true),
                        CiName = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.CiID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animes", "Category_CatID", "dbo.Categories");
            DropIndex("dbo.Animes", new[] { "Category_CatID" });
            DropTable("dbo.Cinemas");
            DropTable("dbo.Categories");
            DropTable("dbo.Animes");
            DropTable("dbo.Admins");
        }
    }
}
