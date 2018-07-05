using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class PromotionProductViewModel
    {
    
        public int ProductID { set; get; }
    
        public int PromotionID { set; get; }

      
        public virtual ProductViewModel Products { set; get; }

      
        public virtual PromotionViewModel Promotions { set; get; }
    }
}