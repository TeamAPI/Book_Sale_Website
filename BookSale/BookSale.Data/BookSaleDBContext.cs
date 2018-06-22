using BookSale.Models.Models;
using System.Data.Entity;

namespace BookSale.Data
{
<<<<<<< HEAD
    public class BookSaleDBContext : DbContext
    {
        public BookSaleDBContext() : base("BookSaleConnection")
=======
    public class BookSaleDbContext : DbContext
    {
        public BookSaleDbContext() : base("BookSaleConnection")
>>>>>>> a858cc096e2caa84237889930ef5ccdf417a89b4
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Account> Accounts { set; get; }
<<<<<<< HEAD
        public DbSet<Account_Permission> Account_permission { set; get; }
        public DbSet<Account_Profile> Account_profiles{ set; get; }
=======
        public DbSet<Account_Permission> Account_Permissions { set; get; }
        public DbSet<Account_Profile> Account_Profiles { set; get; }
>>>>>>> a858cc096e2caa84237889930ef5ccdf417a89b4
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
<<<<<<< HEAD
        public DbSet<Order_Detail> Order_details { set; get; }
        public DbSet<Permission_Access> Permission_access { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Product_Price> Product_Prices { set; get; }
        public DbSet<Product_Warehouse> Product_Warehouses { set; get; }
        public DbSet<Promotion> Promotions { set; get; }
        public DbSet<Promotion_Product> Promotion_Products { set; get; }
        public DbSet<Receipt> Receipts { set; get; }
        public DbSet<Receipt_Detail> Receipt_Details { set; get; }
        public DbSet<ShoppingCart> ShoppingCarts { set; get; }
        public DbSet<ShoppingCart_Detail> ShoppingCart_Details { set; get; }
        public DbSet<Supplyhouse> Supplyhouses { set; get; }
        public DbSet<Warehouse> Warehouses { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
=======
        public DbSet<Order_Detail> Order_Details { set; get; }
        public DbSet<Permission_Access> Permission_Access { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<Product_Price> Product_Prices { set; get; }
        public DbSet<Product_Warehouse> Product_Warehouses { set; get; }
        public DbSet<Promotion_Product> Promotion_Products { set; get; }
        public DbSet<ShoppingCart> ShoppingCarts { set; get; }
        public DbSet<ShoppingCart_Detail> ShoppingCart_Details { set; get; }
        public DbSet<Supplyhouse> Supplyhouses { set; get; }

        public DbSet<Receipt> Receipts { set; get; }
        public DbSet<Receipt_Detail> Receipt_Details { set; get; }
        public DbSet<Warehouse> Warehouses { set; get; }

        protected override void OnModelCreating(DbModelBuilder builder)
>>>>>>> a858cc096e2caa84237889930ef5ccdf417a89b4
        {
        }
    }
}