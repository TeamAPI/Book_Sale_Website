using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("AccountProfiles")]
    public class AccountProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountProfileID { set; get; }

        [MaxLength(50)]
        [Required]
        public string AccountProfileUsername { set; get; }

        public Boolean AccountProfileSex { set; get; }

        public DateTime AccountProfileDateofbirth { set; get; }

        [MaxLength(50)]
        public string AccountProfileEmail { set; get; }

        [MaxLength(150)]
        [Required]
        public string AccountProfileAddress { set; get; }

        [MaxLength(11)]
        [Required]
        public string AccountProfileNumberphone { set; get; }

        [MaxLength(256)]
        public string AcountProfileImages { set; get; }

        public int AccountID { set; get; }

        [ForeignKey("AccountID")]
        public virtual Account Accounts { set; get; }
    }
}