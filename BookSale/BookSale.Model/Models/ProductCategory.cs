using BookSale.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("ProductCategorys")]
    public class ProductCategory : Auditable

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCategoryID { set; get; }

        [MaxLength(256)]
        public string ProductCategoryName { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}