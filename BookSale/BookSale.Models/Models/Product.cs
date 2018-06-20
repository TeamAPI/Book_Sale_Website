using BookSale.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Models.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pro_ID { set; get; }

        [MaxLength(256)]
        [Required]
        public string Pro_Name { set; get; }

        public DateTime Pro_Publicationdate { set; get; }

        public int Pro_Pagenumber { set; get; }

        public int Pro_Quantity { set; get; }

        [MaxLength(50)]
        public string Pro_size { set; get; }

        [MaxLength(150)]
        public string Pro_covertype { set; get; }

        [MaxLength(150)]
        public string Pro_pruducttype { set; get; }

        [MaxLength(100)]
        public string Pro_author { set; get; }

        [MaxLength(100)]
        public string Pro_stralator { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }


        public int Sup_ID { set; get; }

        [ForeignKey("Sup_ID")]
        public virtual Supplyhouse Supplyhouses { set; get; }


        public virtual IEnumerable<Order_Detail> Order_details { set; get; }

        public virtual IEnumerable<Product_Price> Product_Price{ set; get; }

        public virtual IEnumerable<Product_Warehouse> Product_Warehouses{ set; get; }

        public virtual IEnumerable<Promotion_Product> Promotion_Products { set; get; }

        public virtual IEnumerable<Receipt_Detail> Receipt_details{ set; get; }
    }
}
}