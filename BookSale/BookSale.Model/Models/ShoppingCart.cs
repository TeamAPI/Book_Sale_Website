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
        public int ShoppingCartID { set; get; }

        public int Quantity { set; get; }

        public decimal TotalCost { set; get; }

        public virtual IEnumerable<ShoppingCartDetail> ShoppingCartdetails { set; get; }
    }
}