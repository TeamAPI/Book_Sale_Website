using BookSale.Models.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Models.Models
{
    [Table("permission_access")]
    public class Permission_access : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [MaxLength(50)]
        [Required]
        public string Name { set; get; }

        [MaxLength(200)]
        public string Description { set; get; }

        public virtual IEnumerable<Account_permission> account_permissions { set; get; }
    }
}