namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TicketHistories");
            AlterColumn("dbo.TicketHistories", "HistoryId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.TicketHistories", "UserId", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.TicketHistories", "HistoryId");
            CreateIndex("dbo.TicketHistories", "UserId");
            AddForeignKey("dbo.TicketHistories", "UserId", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TicketHistories", "UserId", "dbo.Users");
            DropIndex("dbo.TicketHistories", new[] { "UserId" });
            DropPrimaryKey("dbo.TicketHistories");
            AlterColumn("dbo.TicketHistories", "UserId", c => c.String());
            AlterColumn("dbo.TicketHistories", "HistoryId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.TicketHistories", "HistoryId");
        }
    }
}
