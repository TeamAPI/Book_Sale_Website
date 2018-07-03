using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class SupplyhouseViewModel
    {
       
        public int SupplyhouseID { set; get; }

       
        public string SupplyhouseName { set; get; }


        public string SupplyhouseAddress { set; get; }


        public string SupplyhouseNumberphone { set; get; }

        public virtual IEnumerable<ProductViewModel> Products { set; get; }
    }
}