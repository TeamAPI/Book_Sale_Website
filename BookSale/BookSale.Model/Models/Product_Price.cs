using BookSale.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Model.Models
{
    [Table("Product_Prices")]
    public class Product_Price : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pro_Pri_ID { set; get; }

        public int Pro_ID { set; get; }
        public decimal Price { set; get; }

        [ForeignKey("Pro_ID")]
        public virtual Product Products { set; get; }
    }
}