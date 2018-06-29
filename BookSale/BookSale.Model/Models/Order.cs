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
        public int OrderID { set; get; }

        [MaxLength(256)]
        public string OrderStatus { set; get; }

        public DateTime ApprovalDate { set; get; }

        [MaxLength(256)]
        [Required]
        public string ShippingAddress { set; get; }

        [MaxLength(256)]
        public string PaymentStype { set; get; }

        public decimal TotalCost { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}