using BookSale.Model.Abstract;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("Promotions")]
    public class Promotion : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PromotionID { set; get; }

        [MaxLength(256)]
        [Required]
        public string PromotionName { set; get; }

        public int PromotionValues { set; get; }

        public DateTime Startdate { set; get; }

        public DateTime Finishdate { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }

        public virtual IEnumerable<PromotionProduct> PromotionProducts { set; get; }

        public virtual IEnumerable<PromotionImages> PromotionImages { set; get; }
    }
}