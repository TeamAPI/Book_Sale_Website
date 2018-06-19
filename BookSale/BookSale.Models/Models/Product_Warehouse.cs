using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Models.Models
{
    [Table("Product_Warehouse")]
    public class Product_Warehouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pro_War_ID { set; get; }

        public int Pro_ID { set; get; }

        public int War_ID { set; get; }

        [MaxLength(256)]
        [Required]
        public string Position { set; get; }

        [Required]
        public int Quantity { set; get; }

        [ForeignKey("Pro_ID")]
        public virtual Product Products { set; get; }

        [ForeignKey("War_ID")]
        public virtual Warehouse Warehouses { set; get; }

    }
}