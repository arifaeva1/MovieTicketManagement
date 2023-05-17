namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TicketHistories",
                c => new
                    {
                        HistoryId = c.String(nullable: false, maxLength: 128),
                        HistoryStatus = c.String(),
                        TotalAmount = c.Int(nullable: false),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.HistoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TicketHistories");
        }
    }
}
