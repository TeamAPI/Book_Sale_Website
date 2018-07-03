using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class ShoppingCartViewModel
    {
        public int ShoppingCartID { set; get; }

        public int Quantity { set; get; }

        public decimal TotalCost { set; get; }
        public DateTime created_date { set; get; }
        public int created_by { set; get; }

        public DateTime updated_date { set; get; }
        public int updated_by { set; get; }

        public virtual IEnumerable<ShoppingCartDetailViewModel> ShoppingCartdetails { set; get; }
    }
}