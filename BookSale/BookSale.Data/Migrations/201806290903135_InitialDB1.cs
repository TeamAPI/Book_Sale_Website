namespace BookSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderStatus", c => c.String(maxLength: 256));
            AddColumn("dbo.Products", "Publishinghouse", c => c.String(maxLength: 256));
            AddColumn("dbo.Products", "ProductStatus", c => c.String(maxLength: 256));
            AddColumn("dbo.Promotions", "PromotionStatus", c => c.String(maxLength: 256));
            DropColumn("dbo.Orders", "OrderDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Promotions", "PromotionStatus");
            DropColumn("dbo.Products", "ProductStatus");
            DropColumn("dbo.Products", "Publishinghouse");
            DropColumn("dbo.Orders", "OrderStatus");
        }
    }
}
