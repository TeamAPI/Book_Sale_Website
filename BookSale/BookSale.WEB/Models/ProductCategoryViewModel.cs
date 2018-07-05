using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class ProductCategoryViewModel
    {
        
        public int ProductCategoryID { set; get; }

        public string ProductCategoryName { set; get; }

        public DateTime created_date { set; get; }
        public int created_by { set; get; }

        public DateTime updated_date { set; get; }
        public int updated_by { set; get; }


        public virtual IEnumerable<ProductViewModel> Products { set; get; }

        
    }
}