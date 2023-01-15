namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HistoryOrderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistoryOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberOrder = c.String(nullable: false),
                        ProdusName = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HistoryOrders", "UserId", "dbo.Users");
            DropIndex("dbo.HistoryOrders", new[] { "UserId" });
            DropTable("dbo.HistoryOrders");
        }
    }
}
