using BookSale.Model.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Models.Models
{
    [Table("Promotion_Products")]
    public class Promotion_Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pro_Promo_ID { set; get; }

        public int Pro_ID { set; get; }
        public int Promo_ID { set; get; }

        [ForeignKey("Pro_ID")]
        public virtual Product Products { set; get; }

        [ForeignKey("Promo_ID")]
        public virtual Promotion Promotions { set; get; }
    }
}