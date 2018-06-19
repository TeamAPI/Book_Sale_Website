using BookSale.Models.Abstract;
using BookSale.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("Promotion")]
    public class Promotion : Auditable
    {
        [Key]
        [MaxLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Promo_ID { set; get; }

        [MaxLength(256)]
        [Required]
        public string Promo_Name { set; get; }

        public int Promo_Values { set; get; }

        public DateTime Promo_Startdate { set; get; }

        public DateTime Promo_Finishdate { set; get; }

        public virtual IEnumerable<Order_details> Order_Details { set; get; }

        public virtual IEnumerable<Promotion_Product> Promotion_Products { set; get; }
    }
}