namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Aname = c.String(nullable: false, maxLength: 128),
                        AdminName = c.String(nullable: false, maxLength: 30),
                        AdminPassword = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Aname);
            
            CreateTable(
                "dbo.HallStaffs",
                c => new
                    {
                        HSname = c.String(nullable: false, maxLength: 128),
                        HallStaffName = c.String(nullable: false, maxLength: 30),
                        HallStaffEmail = c.String(nullable: false),
                        HallStaffAddress = c.String(nullable: false),
                        HallStaffPhone = c.Int(nullable: false),
                        HallStaffGender = c.String(nullable: false),
                        HallStaffPassword = c.String(nullable: false, maxLength: 20),
                        HallStaffNid = c.Int(nullable: false),
                        Aname = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.HSname)
                .ForeignKey("dbo.Admins", t => t.Aname)
                .Index(t => t.Aname);
            
            CreateTable(
                "dbo.HallDetails",
                c => new
                    {
                        ZoneCode = c.String(nullable: false, maxLength: 128),
                        ZoneName = c.String(nullable: false, maxLength: 50),
                        ZonePlace = c.String(nullable: false, maxLength: 50),
                        SitCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZoneCode);
            
            CreateTable(
                "dbo.HallReviews",
                c => new
                    {
                        ReviewId = c.String(nullable: false, maxLength: 128),
                        ReviewText = c.String(),
                        UserId = c.String(maxLength: 128),
                        ZoneCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.HallDetails", t => t.ZoneCode)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.ZoneCode);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false),
                        UserEmail = c.String(nullable: false),
                        UserAddress = c.String(nullable: false),
                        UserPhone = c.Int(nullable: false),
                        UserGender = c.String(nullable: false),
                        UserPassword = c.String(nullable: false, maxLength: 20),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.MovieRatings",
                c => new
                    {
                        RatingId = c.String(nullable: false, maxLength: 128),
                        RatingText = c.String(),
                        UserId = c.String(maxLength: 128),
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RatingId)
                .ForeignKey("dbo.Movies", t => t.Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieTitle = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 50),
                        MovieTrailerLink = c.String(nullable: false, maxLength: 50),
                        Date = c.DateTime(nullable: false),
                        AddBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HallRepresenters", t => t.AddBy, cascadeDelete: true)
                .Index(t => t.AddBy);
            
            CreateTable(
                "dbo.HallRepresenters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.String(nullable: false, maxLength: 128),
                        SeatNumber = c.String(),
                        TicketPrice = c.Int(nullable: false),
                        Date = c.String(),
                        ShowTime = c.String(),
                        TotalSeats = c.Int(nullable: false),
                        AvailableSeats = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Movies", t => t.Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.ShowTodays",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        MovieTitle = c.String(nullable: false, maxLength: 50),
                        ScrenType = c.String(nullable: false, maxLength: 50),
                        Time = c.DateTime(nullable: false),
                        AddBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieId)
                .ForeignKey("dbo.HallRepresenters", t => t.AddBy, cascadeDelete: true)
                .Index(t => t.AddBy);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 36),
                        CreationTime = c.DateTime(nullable: false),
                        ExpirationTime = c.DateTime(),
                        Email = c.String(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserTokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 100),
                        CreatedTime = c.DateTime(nullable: false),
                        ExpiredTime = c.DateTime(),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTokens", "UserId", "dbo.Users");
            DropForeignKey("dbo.ShowTodays", "AddBy", "dbo.HallRepresenters");
            DropForeignKey("dbo.HallReviews", "UserId", "dbo.Users");
            DropForeignKey("dbo.MovieRatings", "UserId", "dbo.Users");
            DropForeignKey("dbo.MovieRatings", "Id", "dbo.Movies");
            DropForeignKey("dbo.Tickets", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tickets", "Id", "dbo.Movies");
            DropForeignKey("dbo.Movies", "AddBy", "dbo.HallRepresenters");
            DropForeignKey("dbo.HallReviews", "ZoneCode", "dbo.HallDetails");
            DropForeignKey("dbo.HallStaffs", "Aname", "dbo.Admins");
            DropIndex("dbo.UserTokens", new[] { "UserId" });
            DropIndex("dbo.ShowTodays", new[] { "AddBy" });
            DropIndex("dbo.Tickets", new[] { "Id" });
            DropIndex("dbo.Tickets", new[] { "UserId" });
            DropIndex("dbo.Movies", new[] { "AddBy" });
            DropIndex("dbo.MovieRatings", new[] { "Id" });
            DropIndex("dbo.MovieRatings", new[] { "UserId" });
            DropIndex("dbo.HallReviews", new[] { "ZoneCode" });
            DropIndex("dbo.HallReviews", new[] { "UserId" });
            DropIndex("dbo.HallStaffs", new[] { "Aname" });
            DropTable("dbo.UserTokens");
            DropTable("dbo.Tokens");
            DropTable("dbo.ShowTodays");
            DropTable("dbo.Tickets");
            DropTable("dbo.HallRepresenters");
            DropTable("dbo.Movies");
            DropTable("dbo.MovieRatings");
            DropTable("dbo.Users");
            DropTable("dbo.HallReviews");
            DropTable("dbo.HallDetails");
            DropTable("dbo.HallStaffs");
            DropTable("dbo.Admins");
        }
    }
}
