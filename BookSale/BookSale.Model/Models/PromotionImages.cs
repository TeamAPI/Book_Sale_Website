using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("PromotionImages")]
    public class PromotionImages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PromotionImagesID { set; get; }

        [MaxLength(256)]
        public string PromotionImagesName { set; get; }

        public int PromotionID { set; get; }

        [ForeignKey("PromotiontID")]
        public virtual Promotion Promotions { set; get; }
    }
}