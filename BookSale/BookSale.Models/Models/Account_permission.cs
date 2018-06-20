using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Models.Models
{
    [Table("Account_Permissions")]
    public class Account_Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Acc_Per_ID { set; get; }

        public int Acc_ID { set; get; }

        public int Per_ID { set; get; }

        [ForeignKey("Per_ID")]
        public virtual Permission_Access Permissions { set; get; }
        [ForeignKey("Acc_ID")]
        public virtual Account Accounts { set; get; }
    }
}