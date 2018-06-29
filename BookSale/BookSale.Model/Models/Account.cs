using BookSale.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("Accounts")]
    public class Account : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountID { set; get; }

        [MaxLength(50)]
        [Required]
        public string AccountName { set; get; }

        [MaxLength(20)]
        [Required]
        public string AccountPassword { set; get; }

        [MaxLength(50)]
        [Required]
        public string AccountStatus { set; get; }

        [MaxLength(30)]
        [Required]
        public string AccountType { set; get; }

        public virtual IEnumerable<AccountPermission> AccountPermission { set; get; }

        public virtual IEnumerable<AccountProfile> AccountProfiles { set; get; }
    }
}