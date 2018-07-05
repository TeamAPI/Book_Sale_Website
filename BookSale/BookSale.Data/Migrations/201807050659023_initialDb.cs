namespace BookSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategorys", "created_date", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProductCategorys", "created_by", c => c.Int(nullable: false));
            AddColumn("dbo.ProductCategorys", "updated_date", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProductCategorys", "updated_by", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductCategorys", "updated_by");
            DropColumn("dbo.ProductCategorys", "updated_date");
            DropColumn("dbo.ProductCategorys", "created_by");
            DropColumn("dbo.ProductCategorys", "created_date");
            DropColumn("dbo.Products", "Description");
        }
    }
}
