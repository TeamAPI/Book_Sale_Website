namespace BookSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductPrices", "ProductID", "dbo.Products");
            DropIndex("dbo.ProductPrices", new[] { "ProductID" });
            AddColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropTable("dbo.ProductPrices");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductPrices",
                c => new
                    {
                        ProductPriceID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_date = c.DateTime(),
                        created_by = c.Int(),
                        updated_date = c.DateTime(),
                        updated_by = c.Int(),
                    })
                .PrimaryKey(t => t.ProductPriceID);
            
            DropColumn("dbo.Products", "Price");
            CreateIndex("dbo.ProductPrices", "ProductID");
            AddForeignKey("dbo.ProductPrices", "ProductID", "dbo.Products", "ProductID", cascadeDelete: true);
        }
    }
}
