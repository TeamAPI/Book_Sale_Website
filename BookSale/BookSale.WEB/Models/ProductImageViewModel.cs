using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class ProductImageViewModel
    {
    
        public int ProductImagesID { set; get; }

  
        public string ProductImagesName { set; get; }


        public int ProductID { set; get; }

        public virtual ProductViewModel Products { set; get; }
    }
}