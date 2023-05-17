namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TicketHistories", "TicketId", "dbo.Tickets");
            DropIndex("dbo.TicketHistories", new[] { "TicketId" });
            AlterColumn("dbo.TicketHistories", "TicketId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TicketHistories", "TicketId", c => c.String(maxLength: 128));
            CreateIndex("dbo.TicketHistories", "TicketId");
            AddForeignKey("dbo.TicketHistories", "TicketId", "dbo.Tickets", "TicketId");
        }
    }
}
