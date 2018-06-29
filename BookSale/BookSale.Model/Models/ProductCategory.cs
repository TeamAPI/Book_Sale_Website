using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Model.Models
{
    [Table("ProductCategorys")]
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCategoryID { set; get; }

        [MaxLength(256)]
        public string ProductCategoryName { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}
