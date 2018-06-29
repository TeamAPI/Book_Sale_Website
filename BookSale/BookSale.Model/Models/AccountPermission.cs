using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("AccountPermission")]
    public class AccountPermission
    {
        [Key]
        [Column(Order = 1)]
        public int AccountID { set; get; }

        [Key]
        [Column(Order =2)]
        public int PermissionID { set; get; }

        [ForeignKey("PermissionID")]
        public virtual PermissionAccess PermissionAccess { set; get; }
        [ForeignKey("AccountID")]
        public virtual Account Accounts { set; get; }
    }
}