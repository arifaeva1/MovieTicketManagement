namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TicketHistories");
            AddColumn("dbo.TicketHistories", "TicketId", c => c.String(maxLength: 128));
            AlterColumn("dbo.TicketHistories", "HistoryId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.TicketHistories", "HistoryId");
            CreateIndex("dbo.TicketHistories", "TicketId");
            AddForeignKey("dbo.TicketHistories", "TicketId", "dbo.Tickets", "TicketId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TicketHistories", "TicketId", "dbo.Tickets");
            DropIndex("dbo.TicketHistories", new[] { "TicketId" });
            DropPrimaryKey("dbo.TicketHistories");
            AlterColumn("dbo.TicketHistories", "HistoryId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.TicketHistories", "TicketId");
            AddPrimaryKey("dbo.TicketHistories", "HistoryId");
        }
    }
}
