using BookSale.Model.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("ShoppingCarts")]
    public class ShoppingCart : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sho_ID { set; get; }

        public DateTime Sho_Shoerdate { set; get; }

        public decimal Sho_totalcost { set; get; }

        public virtual IEnumerable<ShoppingCart_Detail> ShoppingCart_details { set; get; }
    }
}