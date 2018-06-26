namespace BookSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Account_Permissions", newName: "Account_Permission");
            DropPrimaryKey("dbo.Account_Permission");
            AddPrimaryKey("dbo.Account_Permission", new[] { "Acc_ID", "Per_ID" });
            DropColumn("dbo.Account_Permission", "Acc_Per_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Account_Permission", "Acc_Per_ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Account_Permission");
            AddPrimaryKey("dbo.Account_Permission", "Acc_Per_ID");
            RenameTable(name: "dbo.Account_Permission", newName: "Account_Permissions");
        }
    }
}
