using BookSale.Model.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("ShoppingCart_Details")]
    public class ShoppingCart_Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sho_Det_ID { set; get; }

        public int Sho_ID { set; get; }
        public int Pro_ID { set; get; }
        public int Sho_Quantity { set; get; }
        public Decimal Sho_Price { set; get; }
        public int Promo_ID { set; get; }

        [ForeignKey("Sho_ID")]
        public virtual ShoppingCart ShoppingCarts { set; get; }

        [ForeignKey("Pro_ID")]
        public virtual Product Product { set; get; }

        [ForeignKey("Promo_ID")]
        public virtual Promotion promotion { set; get; }
    }
}