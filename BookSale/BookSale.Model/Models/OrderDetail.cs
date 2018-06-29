using BookSale.Model.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("orderDetails")]
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailID { set; get; }

        public int OrderID { set; get; }
        public int ProductID { set; get; }

        public int Quantity { set; get; }
        public Decimal Price { set; get; }

        public int PromotionID { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Orders { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }

        [ForeignKey("PromotionID")]
        public virtual Promotion promotions { set; get; }
    }
}
