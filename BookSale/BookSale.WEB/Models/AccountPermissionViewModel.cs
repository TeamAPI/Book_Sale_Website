using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class AccountPermissionViewModel
    {
    
        public int AccountID { set; get; }

      
        public int PermissionID { set; get; }


        public virtual PermisionAccessViewModel PermissionAccess { set; get; }
        
        public virtual AccountViewModel Accounts { set; get; }
    }
}