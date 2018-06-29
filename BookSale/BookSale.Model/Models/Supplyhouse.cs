using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Model.Models
{
    [Table("Supplyhouses")]
    public class Supplyhouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplyhouseID { set; get; }

        [MaxLength(256)]
        public string SupplyhouseName { set; get; }

        [MaxLength(256)]
        public string SupplyhouseAddress { set; get; }

        [MaxLength(11)]
        public string SupplyhouseNumberphone { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}