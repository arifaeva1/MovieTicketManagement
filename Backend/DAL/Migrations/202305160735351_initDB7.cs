namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Halls",
                c => new
                    {
                        HallId = c.String(nullable: false, maxLength: 128),
                        HallName = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        Aname = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.HallId)
                .ForeignKey("dbo.Admins", t => t.Aname)
                .Index(t => t.Aname);
            
            CreateTable(
                "dbo.AdminTokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                        Aname = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.Aname, cascadeDelete: true)
                .Index(t => t.Aname);
            
            CreateTable(
                "dbo.Circulars",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        PublishedDate = c.String(nullable: false),
                        LastDate = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Notices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        PublishedDate = c.DateTime(nullable: false),
                        LastDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Admins", "Type", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdminTokens", "Aname", "dbo.Admins");
            DropForeignKey("dbo.Halls", "Aname", "dbo.Admins");
            DropIndex("dbo.AdminTokens", new[] { "Aname" });
            DropIndex("dbo.Halls", new[] { "Aname" });
            DropColumn("dbo.Admins", "Type");
            DropTable("dbo.Notices");
            DropTable("dbo.Circulars");
            DropTable("dbo.AdminTokens");
            DropTable("dbo.Halls");
        }
    }
}
