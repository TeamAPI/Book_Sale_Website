namespace BookSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductPrices", "ProductID", "dbo.Products");
            DropIndex("dbo.ProductPrices", new[] { "ProductID" });
            DropPrimaryKey("dbo.ProductPrices");
            AddColumn("dbo.ProductPrices", "ProductPriceID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ProductPrices", "ProductID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ProductPrices", "ProductPriceID");
            CreateIndex("dbo.ProductPrices", "ProductID");
            AddForeignKey("dbo.ProductPrices", "ProductID", "dbo.Products", "ProductID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductPrices", "ProductID", "dbo.Products");
            DropIndex("dbo.ProductPrices", new[] { "ProductID" });
            DropPrimaryKey("dbo.ProductPrices");
            AlterColumn("dbo.ProductPrices", "ProductID", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.ProductPrices", "ProductPriceID");
            AddPrimaryKey("dbo.ProductPrices", "ProductID");
            CreateIndex("dbo.ProductPrices", "ProductID");
            AddForeignKey("dbo.ProductPrices", "ProductID", "dbo.Products", "ProductID");
        }
    }
}
