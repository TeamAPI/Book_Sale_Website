using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public string Description { set; get; }


        public int ProductCategoryID { set; get; }

        public DateTime created_date { set; get; }
        public int created_by { set; get; }

        public DateTime updated_date { set; get; }
        public int updated_by { set; get; }

        public virtual ProductCategoryViewModel ProductCategory { set; get; }

   
        public string Author { set; get; }


        public string Stralator { set; get; }


        public string Publishinghouse { set; get; }

        public string ProductStatus { set; get; }

        public int SupplyhouseID { set; get; }

        public virtual SupplyhouseViewModel Supplyhouses { set; get; }


        public virtual IEnumerable<OrderDetailViewModel> Orderdetails { set; get; }

        public virtual IEnumerable<ProductPriceViewModel> ProductPrice { set; get; }

        public virtual IEnumerable<ProductWarehouseViewModel> ProductWarehouses { set; get; }

        public virtual IEnumerable<PromotionProductViewModel> PromotionProducts { set; get; }

        public virtual IEnumerable<ReceiptDetailViewModel> Receiptdetails { set; get; }

        public virtual IEnumerable<ProductImageViewModel> ProductImages { set; get; }
    }
}