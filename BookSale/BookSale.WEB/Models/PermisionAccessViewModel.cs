using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class PermisionAccessViewModel
    {
   
        public int ID { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }
        public DateTime created_date { set; get; }
        public int created_by { set; get; }

        public DateTime updated_date { set; get; }
        public int updated_by { set; get; }

        public virtual IEnumerable<AccountPermissionViewModel> accountpermission { set; get; }
    }
}