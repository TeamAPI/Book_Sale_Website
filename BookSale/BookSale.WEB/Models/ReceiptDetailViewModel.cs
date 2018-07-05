using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class ReceiptDetailViewModel
    {
       
        public int ReceiptID { set; get; }
      
        public int? ProductID { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        
        public virtual ReceiptViewModel Receipts { set; get; }

        public virtual ProductViewModel Products { set; get; }
    }
}