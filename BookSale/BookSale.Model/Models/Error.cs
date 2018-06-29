using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Model.Models
{
    [Table("Errors")]
    public class Error
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ErrorID { set; get; }

        [MaxLength(256)]
        public string Message { set; get; }

        [MaxLength(256)]
        public string StackTrace { set; get; }

        public DateTime CreatedDate { set; get; }
    }
}
