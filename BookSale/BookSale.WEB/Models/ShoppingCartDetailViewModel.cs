using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class ShoppingCartDetailViewModel
    {
     
        public int ShoppingCartID { set; get; }
      
        public int ProductID { set; get; }


        public int Quantity { set; get; }
        public Decimal Price { set; get; }

        public int PromotionID { set; get; }


        public virtual ShoppingCartViewModel ShoppingCarts { set; get; }

      
        public virtual ProductViewModel Product { set; get; }


        public virtual PromotionViewModel promotion { set; get; }
    }
}