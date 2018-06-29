using BookSale.Model.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("PromotionProducts")]
    public class PromotionProduct
    {
        [Key]
        [Column(Order=1)]
        public int ProductID { set; get; }
        [Key]
        [Column(Order = 2)]
        public int PromotionID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }

        [ForeignKey("PromotionID")]
        public virtual Promotion Promotions { set; get; }
    }
}