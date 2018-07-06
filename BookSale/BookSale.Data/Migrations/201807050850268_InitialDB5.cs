namespace BookSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "created_date", c => c.DateTime());
            AlterColumn("dbo.Accounts", "created_by", c => c.Int());
            AlterColumn("dbo.Accounts", "updated_date", c => c.DateTime());
            AlterColumn("dbo.Accounts", "updated_by", c => c.Int());
            AlterColumn("dbo.PermissionAccess", "created_date", c => c.DateTime());
            AlterColumn("dbo.PermissionAccess", "created_by", c => c.Int());
            AlterColumn("dbo.PermissionAccess", "updated_date", c => c.DateTime());
            AlterColumn("dbo.PermissionAccess", "updated_by", c => c.Int());
            AlterColumn("dbo.Orders", "created_date", c => c.DateTime());
            AlterColumn("dbo.Orders", "created_by", c => c.Int());
            AlterColumn("dbo.Orders", "updated_date", c => c.DateTime());
            AlterColumn("dbo.Orders", "updated_by", c => c.Int());
            AlterColumn("dbo.Products", "created_date", c => c.DateTime());
            AlterColumn("dbo.Products", "created_by", c => c.Int());
            AlterColumn("dbo.Products", "updated_date", c => c.DateTime());
            AlterColumn("dbo.Products", "updated_by", c => c.Int());
            AlterColumn("dbo.ProductCategorys", "created_date", c => c.DateTime());
            AlterColumn("dbo.ProductCategorys", "created_by", c => c.Int());
            AlterColumn("dbo.ProductCategorys", "updated_date", c => c.DateTime());
            AlterColumn("dbo.ProductCategorys", "updated_by", c => c.Int());
            AlterColumn("dbo.Promotions", "created_date", c => c.DateTime());
            AlterColumn("dbo.Promotions", "created_by", c => c.Int());
            AlterColumn("dbo.Promotions", "updated_date", c => c.DateTime());
            AlterColumn("dbo.Promotions", "updated_by", c => c.Int());
            AlterColumn("dbo.ProductPrices", "created_date", c => c.DateTime());
            AlterColumn("dbo.ProductPrices", "created_by", c => c.Int());
            AlterColumn("dbo.ProductPrices", "updated_date", c => c.DateTime());
            AlterColumn("dbo.ProductPrices", "updated_by", c => c.Int());
            AlterColumn("dbo.Receipts", "created_date", c => c.DateTime());
            AlterColumn("dbo.Receipts", "created_by", c => c.Int());
            AlterColumn("dbo.Receipts", "updated_date", c => c.DateTime());
            AlterColumn("dbo.Receipts", "updated_by", c => c.Int());
            AlterColumn("dbo.ShoppingCarts", "created_date", c => c.DateTime());
            AlterColumn("dbo.ShoppingCarts", "created_by", c => c.Int());
            AlterColumn("dbo.ShoppingCarts", "updated_date", c => c.DateTime());
            AlterColumn("dbo.ShoppingCarts", "updated_by", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ShoppingCarts", "updated_by", c => c.Int(nullable: false));
            AlterColumn("dbo.ShoppingCarts", "updated_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ShoppingCarts", "created_by", c => c.Int(nullable: false));
            AlterColumn("dbo.ShoppingCarts", "created_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Receipts", "updated_by", c => c.Int(nullable: false));
            AlterColumn("dbo.Receipts", "updated_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Receipts", "created_by", c => c.Int(nullable: false));
            AlterColumn("dbo.Receipts", "created_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProductPrices", "updated_by", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductPrices", "updated_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProductPrices", "created_by", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductPrices", "created_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Promotions", "updated_by", c => c.Int(nullable: false));
            AlterColumn("dbo.Promotions", "updated_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Promotions", "created_by", c => c.Int(nullable: false));
            AlterColumn("dbo.Promotions", "created_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProductCategorys", "updated_by", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductCategorys", "updated_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProductCategorys", "created_by", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductCategorys", "created_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "updated_by", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "updated_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "created_by", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "created_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "updated_by", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "updated_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "created_by", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "created_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PermissionAccess", "updated_by", c => c.Int(nullable: false));
            AlterColumn("dbo.PermissionAccess", "updated_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PermissionAccess", "created_by", c => c.Int(nullable: false));
            AlterColumn("dbo.PermissionAccess", "created_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Accounts", "updated_by", c => c.Int(nullable: false));
            AlterColumn("dbo.Accounts", "updated_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Accounts", "created_by", c => c.Int(nullable: false));
            AlterColumn("dbo.Accounts", "created_date", c => c.DateTime(nullable: false));
        }
    }
}
