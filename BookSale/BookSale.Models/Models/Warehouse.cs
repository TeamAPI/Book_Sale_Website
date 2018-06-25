using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Models.Models
{
    [Table("Warehouses")]
    public class Warehouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int War_ID { set; get; }

        [MaxLength(256)]
        public string War_Name { set; get; }

        [MaxLength(256)]
        public string War_Address { set; get; }

        [MaxLength(11)]
        public string war_numberphone { set; get; }

        public virtual IEnumerable<Product_Warehouse> Product_Warehouses { set; get; }
    }
}