using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class WarehouseViewModel
    {
     
        public int WarehouseID { set; get; }

     
        public string WarehouseName { set; get; }

        public string WarehouseAddress { set; get; }

     
        public string WarehouseNumberphone { set; get; }

        public virtual IEnumerable<ProductWarehouseViewModel> ProductWarehouses { set; get; }
    }
}