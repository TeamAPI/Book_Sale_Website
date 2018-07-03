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

        public virtual IEnumerable<ProductViewModel> Products { set; get; }
    }
}