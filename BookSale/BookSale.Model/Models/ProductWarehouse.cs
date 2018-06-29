using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("ProductWarehouses")]
    public class ProductWarehouse
    {
        [Key]
        [Column(Order=1)]
        public int ProductID { set; get; }

        [Key]
        [Column(Order=2)]
        public int WarehouseID { set; get; }

        [MaxLength(256)]
        [Required]
        public string Position { set; get; }

        [Required]
        public int Quantity { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }

        [ForeignKey("WarehouseID")]
        public virtual Warehouse Warehouses { set; get; }
    }
}