using BookSale.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { set; get; }

        [MaxLength(256)]
        [Required]
        public string ProductName { set; get; }

        public DateTime PublicationDate { set; get; }

        public int Pagenumber { set; get; }

        public int Quantity { set; get; }

        [MaxLength(50)]
        public string Size { set; get; }

        [MaxLength(150)]
        public string Covertype { set; get; }


        public int ProductCategoryID { set; get; }
        [ForeignKey("ProductCategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

        [MaxLength(100)]
        public string Author { set; get; }

        [MaxLength(100)]
        public string Stralator { set; get; }

        [MaxLength(256)]
        public string Publishinghouse { set; get; }

        [MaxLength(256)]
        public string ProductStatus { set; get; }
        [MaxLength(256)]
        public string Description { set; get; }

        public int SupplyhouseID { set; get; }
        [ForeignKey("SupplyhouseID")]
        public virtual Supplyhouse Supplyhouses { set; get; }


        public virtual IEnumerable<OrderDetail> Orderdetails { set; get; }

        public virtual IEnumerable<ProductPrice> ProductPrice { set; get; }

        public virtual IEnumerable<ProductWarehouse> ProductWarehouses { set; get; }

        public virtual IEnumerable<PromotionProduct> PromotionProducts { set; get; }

        public virtual IEnumerable<ReceiptDetail> Receiptdetails { set; get; }

        public virtual IEnumerable<ProductImages> ProductImages { set; get; }
    }
}