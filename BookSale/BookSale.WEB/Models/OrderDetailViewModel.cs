using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class OrderDetailViewModel
    {
      
        public int OrderDetailID { set; get; }

        public int OrderID { set; get; }
        public int ProductID { set; get; }

        public int Quantity { set; get; }
        public Decimal Price { set; get; }

        public int PromotionID { set; get; }

 
        public virtual OrderViewModel Orders { set; get; }

       
        public virtual ProductViewModel Products { set; get; }

     
        public virtual PromotionViewModel promotions { set; get; }
    }
}