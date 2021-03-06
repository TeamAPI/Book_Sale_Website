﻿using BookSale.Model.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace BookSale.Data
{
    public class BookSaleDbContext : IdentityDbContext<ApplicationUser>
    {
        public BookSaleDbContext() : base("BookSaleConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }

        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }

        public DbSet<Product> Products { set; get; }
        public DbSet<ProductWarehouse> ProductWarehouses { set; get; }
        public DbSet<ProductImages> ProductImages { set; get; }
        public DbSet <ProductCategory> ProductCategory { set; get; }
     
        public DbSet<Promotion> Promotions { set; get; }
        public DbSet<PromotionProduct> PromotionProducts { set; get; }
        public DbSet<PromotionImages> PromotionImages { set; get; }


        public DbSet<Receipt> Receipts { set; get; }
        public DbSet<ReceiptDetail> ReceiptDetails { set; get; }

        public DbSet<ShoppingCart> ShoppingCarts { set; get; }
        public DbSet<ShoppingCartDetail> ShoppingCart_Details { set; get; }

        public DbSet<Supplyhouse> Supplyhouses { set; get; }
        public DbSet<Warehouse> Warehouses { set; get; }

        public DbSet<Error> Errors { set; get; }

        public static BookSaleDbContext Create()
        {
            return new BookSaleDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}