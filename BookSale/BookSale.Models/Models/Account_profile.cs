using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Models.Models
{
    [Table("Account_Profiles")]
    public class Account_Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Acc_Prof_ID { set; get; }

        [MaxLength(50)]
        [Required]
        public string Acc_Prof_Username { set; get; }

        public Boolean Acc_Prof_Sex { set; get; }

        public DateTime Acc_Prof_Dateofbirth { set; get; }

        [MaxLength(50)]
        public string Acc_Prof_Email { set; get; }

        [MaxLength(150)]
        [Required]
        public string Acc_Prof_Address { set; get; }

        [MaxLength(11)]
        [Required]
        public string Acc_Prof_Numberphone { set; get; }

        public int Acc_ID { set; get; }

        [ForeignKey("Acc_ID")]
        public virtual Account Accounts { set; get; }
    }
}