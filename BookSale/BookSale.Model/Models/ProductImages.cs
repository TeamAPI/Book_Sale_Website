using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Model.Models
{
    [Table("ProductImages")]
    public class ProductImages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductImagesID { set; get; }

        [MaxLength(256)]
        public string ProductImagesName { set; get; }


        public int ProductID {set; get;} 
        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }
    }
}
