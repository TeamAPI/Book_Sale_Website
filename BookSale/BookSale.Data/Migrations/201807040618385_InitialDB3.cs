namespace BookSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductPrices", "ProductID", "dbo.Products");
            DropIndex("dbo.ProductPrices", new[] { "ProductID" });
            DropPrimaryKey("dbo.orderDetails");
            DropPrimaryKey("dbo.ProductPrices");
            AlterColumn("dbo.ProductPrices", "ProductID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.orderDetails", new[] { "OrderID", "ProductID" });
            AddPrimaryKey("dbo.ProductPrices", "ProductID");
            CreateIndex("dbo.ProductPrices", "ProductID");
            AddForeignKey("dbo.ProductPrices", "ProductID", "dbo.Products", "ProductID");
            DropColumn("dbo.orderDetails", "OrderDetailID");
            DropColumn("dbo.ProductPrices", "ProductPriceID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductPrices", "ProductPriceID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.orderDetails", "OrderDetailID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.ProductPrices", "ProductID", "dbo.Products");
            DropIndex("dbo.ProductPrices", new[] { "ProductID" });
            DropPrimaryKey("dbo.ProductPrices");
            DropPrimaryKey("dbo.orderDetails");
            AlterColumn("dbo.ProductPrices", "ProductID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ProductPrices", "ProductPriceID");
            AddPrimaryKey("dbo.orderDetails", "OrderDetailID");
            CreateIndex("dbo.ProductPrices", "ProductID");
            AddForeignKey("dbo.ProductPrices", "ProductID", "dbo.Products", "ProductID", cascadeDelete: true);
        }
    }
}
