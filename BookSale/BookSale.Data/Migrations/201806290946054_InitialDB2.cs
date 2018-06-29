namespace BookSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ErrorID = c.Int(nullable: false, identity: true),
                        Message = c.String(maxLength: 256),
                        StackTrace = c.String(maxLength: 256),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ErrorID);
            
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        ProductImagesID = c.Int(nullable: false, identity: true),
                        ProductImagesName = c.String(maxLength: 256),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductImagesID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.PromotionImages",
                c => new
                    {
                        PromotionImagesID = c.Int(nullable: false, identity: true),
                        PromotionImagesName = c.String(maxLength: 256),
                        PromotionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PromotionImagesID)
                .ForeignKey("dbo.Promotions", t => t.PromotionID, cascadeDelete: true)
                .Index(t => t.PromotionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PromotionImages", "PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.ProductImages", "ProductID", "dbo.Products");
            DropIndex("dbo.PromotionImages", new[] { "PromotionID" });
            DropIndex("dbo.ProductImages", new[] { "ProductID" });
            DropTable("dbo.PromotionImages");
            DropTable("dbo.ProductImages");
            DropTable("dbo.Errors");
        }
    }
}
