using BookSale.Model.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Models.Models
{ BookSale/BookSale.Models/Models/Order_Detail.cs
    [Table("order_Details")]
    public class Order_Detail 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ord_det_ID { set; get; }

        public int Ord_ID { set; get; }
        public int Pro_ID { set; get; }
        public int Ord_Quantity { set; get; }
        public Decimal Ord_Price { set; get; }
        public int Promo_ID { set; get; }

        [ForeignKey("Ord_ID")]
        public virtual Order Orders{ set; get; }

        [ForeignKey("Pro_ID")]
        public virtual Product Products { set; get; }

        [ForeignKey("Promo_ID")]
        public virtual Promotion promotions { set; get; }
    }
}
