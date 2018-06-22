namespace BookSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account_Permissions",
                c => new
                    {
                        Acc_Per_ID = c.Int(nullable: false, identity: true),
                        Acc_ID = c.Int(nullable: false),
                        Per_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Acc_Per_ID)
                .ForeignKey("dbo.Accounts", t => t.Acc_ID, cascadeDelete: true)
                .ForeignKey("dbo.Permission_Access", t => t.Per_ID, cascadeDelete: true)
                .Index(t => t.Acc_ID)
                .Index(t => t.Per_ID);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Acc_ID = c.Int(nullable: false, identity: true),
                        Acc_Name = c.String(nullable: false, maxLength: 50),
                        Acc_Password = c.String(nullable: false, maxLength: 20),
                        Acc_Status = c.String(nullable: false, maxLength: 50),
                        Acc_AccountType = c.String(nullable: false, maxLength: 30),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Acc_ID);
            
            CreateTable(
                "dbo.Permission_Access",
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
                "dbo.account_Profiles",
                c => new
                    {
                        Acc_Prof_ID = c.Int(nullable: false, identity: true),
                        Acc_Prof_Username = c.String(nullable: false, maxLength: 50),
                        Acc_Prof_Sex = c.Boolean(nullable: false),
                        Acc_Prof_Dateofbirth = c.DateTime(nullable: false),
                        Acc_Prof_Email = c.String(maxLength: 50),
                        Acc_Prof_Address = c.String(nullable: false, maxLength: 150),
                        Acc_Prof_Numberphone = c.String(nullable: false, maxLength: 11),
                        Acc_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Acc_Prof_ID)
                .ForeignKey("dbo.Accounts", t => t.Acc_ID, cascadeDelete: true)
                .Index(t => t.Acc_ID);
            
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
                "dbo.Order_Details",
                c => new
                    {
                        ord_det_ID = c.Int(nullable: false, identity: true),
                        Ord_ID = c.Int(nullable: false),
                        Pro_ID = c.Int(nullable: false),
                        Ord_Quantity = c.Int(nullable: false),
                        Ord_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Promo_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ord_det_ID)
                .ForeignKey("dbo.Orders", t => t.Ord_ID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Pro_ID, cascadeDelete: true)
                .ForeignKey("dbo.Promotions", t => t.Promo_ID, cascadeDelete: true)
                .Index(t => t.Ord_ID)
                .Index(t => t.Pro_ID)
                .Index(t => t.Promo_ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Ord_ID = c.Int(nullable: false, identity: true),
                        Ord_orderdate = c.DateTime(nullable: false),
                        Ord_dayofapproval = c.DateTime(nullable: false),
                        Ord_shippingaddress = c.String(nullable: false, maxLength: 256),
                        Ord_paymentstype = c.String(maxLength: 256),
                        Ord_totalcost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ord_ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Pro_ID = c.Int(nullable: false, identity: true),
                        Pro_Name = c.String(nullable: false, maxLength: 256),
                        Pro_Publicationdate = c.DateTime(nullable: false),
                        Pro_Pagenumber = c.Int(nullable: false),
                        Pro_Quantity = c.Int(nullable: false),
                        Pro_size = c.String(maxLength: 50),
                        Pro_covertype = c.String(maxLength: 150),
                        Pro_pruducttype = c.String(maxLength: 150),
                        Pro_author = c.String(maxLength: 100),
                        Pro_stralator = c.String(maxLength: 100),
                        Image = c.String(maxLength: 256),
                        Sup_ID = c.Int(nullable: false),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pro_ID)
                .ForeignKey("dbo.Supplyhouses", t => t.Sup_ID, cascadeDelete: true)
                .Index(t => t.Sup_ID);
            
            CreateTable(
                "dbo.Supplyhouses",
                c => new
                    {
                        Sup_ID = c.Int(nullable: false, identity: true),
                        Sup_Name = c.String(maxLength: 256),
                        Sup_Address = c.String(maxLength: 256),
                        Sup_numberphone = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.Sup_ID);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        Promo_ID = c.Int(nullable: false, identity: true),
                        Promo_Name = c.String(nullable: false, maxLength: 256),
                        Promo_Values = c.Int(nullable: false),
                        Promo_Startdate = c.DateTime(nullable: false),
                        Promo_Finishdate = c.DateTime(nullable: false),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Promo_ID);
            
            CreateTable(
                "dbo.Product_Prices",
                c => new
                    {
                        Pro_Pri_ID = c.Int(nullable: false, identity: true),
                        Pro_ID = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pro_Pri_ID)
                .ForeignKey("dbo.Products", t => t.Pro_ID, cascadeDelete: true)
                .Index(t => t.Pro_ID);
            
            CreateTable(
                "dbo.Product_Warehouses",
                c => new
                    {
                        Pro_War_ID = c.Int(nullable: false, identity: true),
                        Pro_ID = c.Int(nullable: false),
                        War_ID = c.Int(nullable: false),
                        Position = c.String(nullable: false, maxLength: 256),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pro_War_ID)
                .ForeignKey("dbo.Products", t => t.Pro_ID, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.War_ID, cascadeDelete: true)
                .Index(t => t.Pro_ID)
                .Index(t => t.War_ID);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        War_ID = c.Int(nullable: false, identity: true),
                        War_Name = c.String(maxLength: 256),
                        War_Address = c.String(maxLength: 256),
                        war_numberphone = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.War_ID);
            
            CreateTable(
                "dbo.Promotion_Products",
                c => new
                    {
                        Pro_Promo_ID = c.Int(nullable: false, identity: true),
                        Pro_ID = c.Int(nullable: false),
                        Promo_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pro_Promo_ID)
                .ForeignKey("dbo.Products", t => t.Pro_ID, cascadeDelete: true)
                .ForeignKey("dbo.Promotions", t => t.Promo_ID, cascadeDelete: true)
                .Index(t => t.Pro_ID)
                .Index(t => t.Promo_ID);
            
            CreateTable(
                "dbo.Receipt_Details",
                c => new
                    {
                        Rec_Det_ID = c.Int(nullable: false, identity: true),
                        Rec_ID = c.Int(nullable: false),
                        Pro_ID = c.Int(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Rec_Det_ID)
                .ForeignKey("dbo.Products", t => t.Pro_ID)
                .ForeignKey("dbo.Receipts", t => t.Rec_ID, cascadeDelete: true)
                .Index(t => t.Rec_ID)
                .Index(t => t.Pro_ID);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        Rec_ID = c.Int(nullable: false, identity: true),
                        Sup_ID = c.Int(nullable: false),
                        War_ID = c.Int(nullable: false),
                        Rec_ToTalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Rec_ID);
            
            CreateTable(
                "dbo.ShoppingCart_Details",
                c => new
                    {
                        Sho_Det_ID = c.Int(nullable: false, identity: true),
                        Sho_ID = c.Int(nullable: false),
                        Pro_ID = c.Int(nullable: false),
                        Sho_Quantity = c.Int(nullable: false),
                        Sho_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Promo_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sho_Det_ID)
                .ForeignKey("dbo.Products", t => t.Pro_ID, cascadeDelete: true)
                .ForeignKey("dbo.Promotions", t => t.Promo_ID, cascadeDelete: true)
                .ForeignKey("dbo.ShoppingCarts", t => t.Sho_ID, cascadeDelete: true)
                .Index(t => t.Sho_ID)
                .Index(t => t.Pro_ID)
                .Index(t => t.Promo_ID);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        Sho_ID = c.Int(nullable: false, identity: true),
                        Sho_Shoerdate = c.DateTime(nullable: false),
                        Sho_totalcost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_date = c.DateTime(nullable: false),
                        created_by = c.Int(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        updated_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sho_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCart_Details", "Sho_ID", "dbo.ShoppingCarts");
            DropForeignKey("dbo.ShoppingCart_Details", "Promo_ID", "dbo.Promotions");
            DropForeignKey("dbo.ShoppingCart_Details", "Pro_ID", "dbo.Products");
            DropForeignKey("dbo.Receipt_Details", "Rec_ID", "dbo.Receipts");
            DropForeignKey("dbo.Receipt_Details", "Pro_ID", "dbo.Products");
            DropForeignKey("dbo.Promotion_Products", "Promo_ID", "dbo.Promotions");
            DropForeignKey("dbo.Promotion_Products", "Pro_ID", "dbo.Products");
            DropForeignKey("dbo.Product_Warehouses", "War_ID", "dbo.Warehouses");
            DropForeignKey("dbo.Product_Warehouses", "Pro_ID", "dbo.Products");
            DropForeignKey("dbo.Product_Prices", "Pro_ID", "dbo.Products");
            DropForeignKey("dbo.Order_Details", "Promo_ID", "dbo.Promotions");
            DropForeignKey("dbo.Order_Details", "Pro_ID", "dbo.Products");
            DropForeignKey("dbo.Products", "Sup_ID", "dbo.Supplyhouses");
            DropForeignKey("dbo.Order_Details", "Ord_ID", "dbo.Orders");
            DropForeignKey("dbo.Menus", "GroupID", "dbo.MenuGroups");
            DropForeignKey("dbo.account_Profiles", "Acc_ID", "dbo.Accounts");
            DropForeignKey("dbo.Account_Permissions", "Per_ID", "dbo.Permission_Access");
            DropForeignKey("dbo.Account_Permissions", "Acc_ID", "dbo.Accounts");
            DropIndex("dbo.ShoppingCart_Details", new[] { "Promo_ID" });
            DropIndex("dbo.ShoppingCart_Details", new[] { "Pro_ID" });
            DropIndex("dbo.ShoppingCart_Details", new[] { "Sho_ID" });
            DropIndex("dbo.Receipt_Details", new[] { "Pro_ID" });
            DropIndex("dbo.Receipt_Details", new[] { "Rec_ID" });
            DropIndex("dbo.Promotion_Products", new[] { "Promo_ID" });
            DropIndex("dbo.Promotion_Products", new[] { "Pro_ID" });
            DropIndex("dbo.Product_Warehouses", new[] { "War_ID" });
            DropIndex("dbo.Product_Warehouses", new[] { "Pro_ID" });
            DropIndex("dbo.Product_Prices", new[] { "Pro_ID" });
            DropIndex("dbo.Products", new[] { "Sup_ID" });
            DropIndex("dbo.Order_Details", new[] { "Promo_ID" });
            DropIndex("dbo.Order_Details", new[] { "Pro_ID" });
            DropIndex("dbo.Order_Details", new[] { "Ord_ID" });
            DropIndex("dbo.Menus", new[] { "GroupID" });
            DropIndex("dbo.account_Profiles", new[] { "Acc_ID" });
            DropIndex("dbo.Account_Permissions", new[] { "Per_ID" });
            DropIndex("dbo.Account_Permissions", new[] { "Acc_ID" });
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.ShoppingCart_Details");
            DropTable("dbo.Receipts");
            DropTable("dbo.Receipt_Details");
            DropTable("dbo.Promotion_Products");
            DropTable("dbo.Warehouses");
            DropTable("dbo.Product_Warehouses");
            DropTable("dbo.Product_Prices");
            DropTable("dbo.Promotions");
            DropTable("dbo.Supplyhouses");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.Order_Details");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Footers");
            DropTable("dbo.account_Profiles");
            DropTable("dbo.Permission_Access");
            DropTable("dbo.Accounts");
            DropTable("dbo.Account_Permissions");
        }
    }
}
