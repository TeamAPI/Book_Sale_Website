using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Models.Models
{
    [Table("Supplyhouse")]
    public class Supplyhouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sup_ID { set; get; }

        [MaxLength(256)]
        public string Sup_Name { set; get; }

        [MaxLength(256)]
        public string Sup_Address { set; get; }

        [MaxLength(11)]
        public string Sup_numberphone { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }

    }
}
