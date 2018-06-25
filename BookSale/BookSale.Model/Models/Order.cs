using BookSale.Model.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ord_ID { set; get; }

        public DateTime Ord_orderdate { set; get; }

        public DateTime Ord_dayofapproval { set; get; }

        [MaxLength(256)]
        [Required]
        public string Ord_shippingaddress { set; get; }

        [MaxLength(256)]
        public string Ord_paymentstype { set; get; }

        public decimal Ord_totalcost { set; get; }

        public virtual IEnumerable<Order_Detail> Order_Details { set; get; }
    }
}