using BookSale.Model.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("ShoppingCartDetails")]
    public class ShoppingCartDetail
    {
        [Key]
        [Column(Order =1)]
        public int ShoppingCartID { set; get; }
        [Key]
        [Column(Order = 2)]
        public int ProductID { set; get; }


        public int Quantity { set; get; }
        public Decimal Price { set; get; }

        public int PromotionID { set; get; }

        [ForeignKey("ShoppingCartID")]
        public virtual ShoppingCart ShoppingCarts { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [ForeignKey("PromotionID")]
        public virtual Promotion promotion { set; get; }
    }
}