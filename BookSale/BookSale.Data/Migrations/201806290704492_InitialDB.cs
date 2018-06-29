namespace BookSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountPermission",
                c => new
                    {
                        AccountID = c.Int(nullable: false),
                        PermissionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AccountID, t.PermissionID })
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.PermissionAccess", t => t.PermissionID, cascadeDelete: true)
                .Index(t => t.AccountID)
                .Index(t => t.PermissionID);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountID = c.Int(nullable: false, identity: true),
                        AccountName = c.String(nullable: false, maxLength: 50),
                        AccountPassword = c.String(nullable: false, maxLength: 20),
                        AccountStatus = c.String(nullable: false, maxLength: 50),
                        AccountType = c.String(nullable: false, maxLength: 30),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccountID);
            
            CreateTable(
                "dbo.PermissionAccess",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 200),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AccountProfiles",
                c => new
                    {
                        AccountProfileID = c.Int(nullable: false, identity: true),
                        AccountProfileUsername = c.String(nullable: false, maxLength: 50),
                        AccountProfileSex = c.Boolean(nullable: false),
                        AccountProfileDateofbirth = c.DateTime(nullable: false),
                        AccountProfileEmail = c.String(maxLength: 50),
                        AccountProfileAddress = c.String(nullable: false, maxLength: 150),
                        AccountProfileNumberphone = c.String(nullable: false, maxLength: 11),
                        AcountProfileImages = c.String(maxLength: 256),
                        AccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccountProfileID)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Content = c.String(nullable: false, maxLength: 100),
                        Type = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        URL = c.String(nullable: false, maxLength: 256),
                        DisplayOrder = c.Int(),
                        GroupID = c.Int(nullable: false),
                        Target = c.String(maxLength: 10),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuGroups", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.orderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Promotions", t => t.PromotionID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID)
                .Index(t => t.PromotionID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        ApprovalDate = c.DateTime(nullable: false),
                        ShippingAddress = c.String(nullable: false, maxLength: 256),
                        PaymentStype = c.String(maxLength: 256),
                        TotalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 256),
                        PublicationDate = c.DateTime(nullable: false),
                        Pagenumber = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Size = c.String(maxLength: 50),
                        Covertype = c.String(maxLength: 150),
                        ProductCategoryID = c.Int(nullable: false),
                        Author = c.String(maxLength: 100),
                        Stralator = c.String(maxLength: 100),
                        SupplyhouseID = c.Int(nullable: false),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.ProductCategorys", t => t.ProductCategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Supplyhouses", t => t.SupplyhouseID, cascadeDelete: true)
                .Index(t => t.ProductCategoryID)
                .Index(t => t.SupplyhouseID);
            
            CreateTable(
                "dbo.ProductCategorys",
                c => new
                    {
                        ProductCategoryID = c.Int(nullable: false, identity: true),
                        ProductCategoryName = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ProductCategoryID);
            
            CreateTable(
                "dbo.Supplyhouses",
                c => new
                    {
                        SupplyhouseID = c.Int(nullable: false, identity: true),
                        SupplyhouseName = c.String(maxLength: 256),
                        SupplyhouseAddress = c.String(maxLength: 256),
                        SupplyhouseNumberphone = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.SupplyhouseID);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        PromotionID = c.Int(nullable: false, identity: true),
                        PromotionName = c.String(nullable: false, maxLength: 256),
                        PromotionValues = c.Int(nullable: false),
                        Startdate = c.DateTime(nullable: false),
                        Finishdate = c.DateTime(nullable: false),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PromotionID);
            
            CreateTable(
                "dbo.ProductPrices",
                c => new
                    {
                        ProductPriceID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductPriceID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.ProductWarehouses",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        WarehouseID = c.Int(nullable: false),
                        Position = c.String(nullable: false, maxLength: 256),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.WarehouseID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.WarehouseID);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        WarehouseID = c.Int(nullable: false, identity: true),
                        WarehouseName = c.String(maxLength: 256),
                        WarehouseAddress = c.String(maxLength: 256),
                        WarehouseNumberphone = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.WarehouseID);
            
            CreateTable(
                "dbo.PromotionProducts",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        PromotionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.PromotionID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Promotions", t => t.PromotionID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.PromotionID);
            
            CreateTable(
                "dbo.ReceiptDetails",
                c => new
                    {
                        ReceiptID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ReceiptID, t.ProductID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Receipts", t => t.ReceiptID, cascadeDelete: true)
                .Index(t => t.ReceiptID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        ReceiptID = c.Int(nullable: false, identity: true),
                        SupplyhouseID = c.Int(nullable: false),
                        WarehouseID = c.Int(nullable: false),
                        ToTalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReceiptID);
            
            CreateTable(
                "dbo.ShoppingCartDetails",
                c => new
                    {
                        ShoppingCartID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ShoppingCartID, t.ProductID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Promotions", t => t.PromotionID, cascadeDelete: true)
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCartID, cascadeDelete: true)
                .Index(t => t.ShoppingCartID)
                .Index(t => t.ProductID)
                .Index(t => t.PromotionID);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        ShoppingCartID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        TotalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShoppingCartID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCartDetails", "ShoppingCartID", "dbo.ShoppingCarts");
            DropForeignKey("dbo.ShoppingCartDetails", "PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.ShoppingCartDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ReceiptDetails", "ReceiptID", "dbo.Receipts");
            DropForeignKey("dbo.ReceiptDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.PromotionProducts", "PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.PromotionProducts", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductWarehouses", "WarehouseID", "dbo.Warehouses");
            DropForeignKey("dbo.ProductWarehouses", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductPrices", "ProductID", "dbo.Products");
            DropForeignKey("dbo.orderDetails", "PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.orderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "SupplyhouseID", "dbo.Supplyhouses");
            DropForeignKey("dbo.Products", "ProductCategoryID", "dbo.ProductCategorys");
            DropForeignKey("dbo.orderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Menus", "GroupID", "dbo.MenuGroups");
            DropForeignKey("dbo.AccountProfiles", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.AccountPermission", "PermissionID", "dbo.PermissionAccess");
            DropForeignKey("dbo.AccountPermission", "AccountID", "dbo.Accounts");
            DropIndex("dbo.ShoppingCartDetails", new[] { "PromotionID" });
            DropIndex("dbo.ShoppingCartDetails", new[] { "ProductID" });
            DropIndex("dbo.ShoppingCartDetails", new[] { "ShoppingCartID" });
            DropIndex("dbo.ReceiptDetails", new[] { "ProductID" });
            DropIndex("dbo.ReceiptDetails", new[] { "ReceiptID" });
            DropIndex("dbo.PromotionProducts", new[] { "PromotionID" });
            DropIndex("dbo.PromotionProducts", new[] { "ProductID" });
            DropIndex("dbo.ProductWarehouses", new[] { "WarehouseID" });
            DropIndex("dbo.ProductWarehouses", new[] { "ProductID" });
            DropIndex("dbo.ProductPrices", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "SupplyhouseID" });
            DropIndex("dbo.Products", new[] { "ProductCategoryID" });
            DropIndex("dbo.orderDetails", new[] { "PromotionID" });
            DropIndex("dbo.orderDetails", new[] { "ProductID" });
            DropIndex("dbo.orderDetails", new[] { "OrderID" });
            DropIndex("dbo.Menus", new[] { "GroupID" });
            DropIndex("dbo.AccountProfiles", new[] { "AccountID" });
            DropIndex("dbo.AccountPermission", new[] { "PermissionID" });
            DropIndex("dbo.AccountPermission", new[] { "AccountID" });
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.ShoppingCartDetails");
            DropTable("dbo.Receipts");
            DropTable("dbo.ReceiptDetails");
            DropTable("dbo.PromotionProducts");
            DropTable("dbo.Warehouses");
            DropTable("dbo.ProductWarehouses");
            DropTable("dbo.ProductPrices");
            DropTable("dbo.Promotions");
            DropTable("dbo.Supplyhouses");
            DropTable("dbo.ProductCategorys");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.orderDetails");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Footers");
            DropTable("dbo.AccountProfiles");
            DropTable("dbo.PermissionAccess");
            DropTable("dbo.Accounts");
            DropTable("dbo.AccountPermission");
        }
    }
}
