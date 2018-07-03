using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class PromotionViewModel
    {

        public int PromotionID { set; get; }

  
        public string PromotionName { set; get; }

        public int PromotionValues { set; get; }

        public DateTime Startdate { set; get; }

        public DateTime Finishdate { set; get; }


        public string PromotionStatus { set; get; }
        public DateTime created_date { set; get; }
        public int created_by { set; get; }

        public DateTime updated_date { set; get; }
        public int updated_by { set; get; }

        public virtual IEnumerable<OrderDetailViewModel> OrderDetails { set; get; }

        public virtual IEnumerable<PromotionProductViewModel> PromotionProducts { set; get; }

        public virtual IEnumerable<PromotionImagesViewModel> PromotionImages { set; get; }
    }
}