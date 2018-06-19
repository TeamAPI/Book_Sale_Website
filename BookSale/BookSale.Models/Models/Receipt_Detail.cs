using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Models.Models
{
    public class Receipt_Detail
    {
        public int Rec_ID { set; get; }
        public int? Pro_ID { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        [ForeignKey("Rec_ID")]
        public virtual Receipt Receipts { set; get; }

        [ForeignKey("Pro_ID")]
        public virtual Product Products { set; get; }


    }
}
