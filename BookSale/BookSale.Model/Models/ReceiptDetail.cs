using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Model.Models
{
    [Table("ReceiptDetails")]
    public class ReceiptDetail
    {
        [Key]
        [Column(Order =1)]
        public int ReceiptID { set; get; }
        [Key]
        [Column(Order = 2)]
        public int? ProductID { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        [ForeignKey("ReceiptID")]
        public virtual Receipt Receipts { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }
    }
}