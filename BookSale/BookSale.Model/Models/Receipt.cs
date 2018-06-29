using BookSale.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("Receipts")]
    public class Receipt : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceiptID { set; get; }

        public int SupplyhouseID { set; get; }

        public int WarehouseID { set; get; }

        public decimal ToTalCost { set; get; }

        public virtual IEnumerable<ReceiptDetail> ReceiptDetails { set; get; }
    }
}