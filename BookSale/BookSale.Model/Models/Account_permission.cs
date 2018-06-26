using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("Account_Permission")]
    public class Account_Permission
    {
        [Key]
        [Column(Order = 1)]
        public int Acc_ID { set; get; }

        [Key]
        [Column(Order =2)]
        public int Per_ID { set; get; }

        [ForeignKey("Per_ID")]
        public virtual Permission_Access Permission_Access { set; get; }
        [ForeignKey("Acc_ID")]
        public virtual Account Accounts { set; get; }
    }
}