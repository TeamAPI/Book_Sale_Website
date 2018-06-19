using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Models.Models
{
    [Table("account_permission")]
    public class Account_permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Acc_Per_ID { set; get; }

        public int Acc_ID { set; get; }

        public int Per_ID { set; get; }

        [ForeignKey("Per_ID")]
        public virtual Permission_access Permissions { set; get; }
        [ForeignKey("Acc_ID")]
        public virtual Account Accounts { set; get; }
    }
}