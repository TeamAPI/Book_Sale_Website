using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class ProductWarehouseViewModel
    {
 
        public int ProductID { set; get; }

 
        public int WarehouseID { set; get; }

        public string Position { set; get; }


        public int Quantity { set; get; }

        public virtual ProductViewModel Products { set; get; }


        public virtual WarehouseViewModel Warehouses { set; get; }
    }
}