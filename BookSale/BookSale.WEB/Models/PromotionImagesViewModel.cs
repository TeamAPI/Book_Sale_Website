using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class PromotionImagesViewModel
    {
       
        public int PromotionImagesID { set; get; }


        public string PromotionImagesName { set; get; }

        public int PromotionID { set; get; }


        public virtual PromotionViewModel Promotions { set; get; }
    }
}