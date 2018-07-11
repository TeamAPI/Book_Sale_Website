namespace BookSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntergrateAspnetIdentity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AccountPermission", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.AccountPermission", "PermissionID", "dbo.PermissionAccess");
            DropForeignKey("dbo.AccountProfiles", "AccountID", "dbo.Accounts");
            DropIndex("dbo.AccountPermission", new[] { "AccountID" });
            DropIndex("dbo.AccountPermission", new[] { "PermissionID" });
            DropIndex("dbo.AccountProfiles", new[] { "AccountID" });
            CreateTable(
                "dbo.IdentityRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.IdentityRoles", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(maxLength: 256),
                        Address = c.String(maxLength: 256),
                        BirthDay = c.DateTime(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            DropTable("dbo.AccountPermission");
            DropTable("dbo.Accounts");
            DropTable("dbo.PermissionAccess");
            DropTable("dbo.AccountProfiles");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.AccountProfileID);
            
            CreateTable(
                "dbo.PermissionAccess",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 200),
                        created_date = c.DateTime(),
                        created_by = c.Int(),
                        updated_date = c.DateTime(),
                        updated_by = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountID = c.Int(nullable: false, identity: true),
                        AccountName = c.String(nullable: false, maxLength: 50),
                        AccountPassword = c.String(nullable: false, maxLength: 20),
                        AccountStatus = c.String(nullable: false, maxLength: 50),
                        AccountType = c.String(nullable: false, maxLength: 30),
                        created_date = c.DateTime(),
                        created_by = c.Int(),
                        updated_date = c.DateTime(),
                        updated_by = c.Int(),
                    })
                .PrimaryKey(t => t.AccountID);
            
            CreateTable(
                "dbo.AccountPermission",
                c => new
                    {
                        AccountID = c.Int(nullable: false),
                        PermissionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AccountID, t.PermissionID });
            
            DropForeignKey("dbo.IdentityUserRoles", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserLogins", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserClaims", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
            DropIndex("dbo.IdentityUserLogins", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityRole_Id" });
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserClaims");
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.IdentityRoles");
            CreateIndex("dbo.AccountProfiles", "AccountID");
            CreateIndex("dbo.AccountPermission", "PermissionID");
            CreateIndex("dbo.AccountPermission", "AccountID");
            AddForeignKey("dbo.AccountProfiles", "AccountID", "dbo.Accounts", "AccountID", cascadeDelete: true);
            AddForeignKey("dbo.AccountPermission", "PermissionID", "dbo.PermissionAccess", "ID", cascadeDelete: true);
            AddForeignKey("dbo.AccountPermission", "AccountID", "dbo.Accounts", "AccountID", cascadeDelete: true);
        }
    }
}
