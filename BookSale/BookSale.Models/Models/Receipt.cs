using BookSale.Models.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Models.Models
{
    public class Receipt : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Rec_ID { set; get; }

        public int Sup_ID { set; get; }

        public int War_ID { set; get; }

        public decimal Rec_ToTalCost { set; get; }

        public virtual IEnumerable<Receipt_Detail> Receipt_Details { set; get; }
    }
}