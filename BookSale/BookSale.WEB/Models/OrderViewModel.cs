using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class OrderViewModel
    {
    
        public int OrderID { set; get; }

      
        public string OrderStatus { set; get; }

        public DateTime ApprovalDate { set; get; }

     
        public string ShippingAddress { set; get; }

        
        public string PaymentStype { set; get; }

        public decimal TotalCost { set; get; }
        public DateTime created_date { set; get; }
        public int created_by { set; get; }

        public DateTime updated_date { set; get; }
        public int updated_by { set; get; }
        public virtual IEnumerable<OrderDetailViewModel> OrderDetails { set; get; }
    }
}