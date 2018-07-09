using BookSale.Model.Models;
using System;
using System.Collections.Generic;

namespace BookSale.WEB.Models
{
    public class ProductViewModel
    {
        public int ProductID { set; get; }

        public string ProductName { set; get; }

        public DateTime PublicationDate { set; get; }

        public int Pagenumber { set; get; }

        public int Quantity { set; get; }

        public string Size { set; get; }

        public string Covertype { set; get; }

        public int ProductCategoryID { set; get; }

        public virtual ProductCategory ProductCategory { set; get; }

        public string Author { set; get; }

        public string Stralator { set; get; }

        public string Publishinghouse { set; get; }

        public string ProductStatus { set; get; }
        public string Description { set; get; }

        public int SupplyhouseID { set; get; }

        public decimal Price { set; get; }

        public virtual Supplyhouse Supplyhouses { set; get; }

        public virtual IEnumerable<OrderDetail> Orderdetails { set; get; }


        public virtual IEnumerable<ProductWarehouse> ProductWarehouses { set; get; }

        public virtual IEnumerable<PromotionProduct> PromotionProducts { set; get; }

        public virtual IEnumerable<ReceiptDetail> Receiptdetails { set; get; }

        public virtual IEnumerable<ProductImages> ProductImages { set; get; }

        public DateTime? created_date { set; get; }
        public int? created_by { set; get; }

        public DateTime? updated_date { set; get; }
        public int? updated_by { set; get; }
    }
}