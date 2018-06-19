using BookSale.Models.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Models.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sho_ID { set; get; }

        public DateTime Sho_Shoerdate { set; get; }

        public decimal Sho_totalcost { set; get; }

        public virtual IEnumerable<ShoppingCart_details> ShoppingCart_details { set; get; }
    }
}