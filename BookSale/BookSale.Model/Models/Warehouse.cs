using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Model.Models
{
    [Table("Warehouses")]
    public class Warehouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WarehouseID { set; get; }

        [MaxLength(256)]
        public string WarehouseName { set; get; }

        [MaxLength(256)]
        public string WarehouseAddress { set; get; }

        [MaxLength(11)]
        public string WarehouseNumberphone { set; get; }

        public virtual IEnumerable<ProductWarehouse> ProductWarehouses { set; get; }
    }
}