using BookSale.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Models
{
    [Table("Permission_Access")]
    public class Permission_Access : Auditable
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