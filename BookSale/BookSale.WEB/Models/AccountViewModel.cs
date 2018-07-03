using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class AccountViewModel
    {
      
        public int AccountID { set; get; }

        public string AccountName { set; get; }

        
        public string AccountPassword { set; get; }

      
        public string AccountStatus { set; get; }


       
        public string AccountType { set; get; }
        public DateTime created_date { set; get; }
        public int created_by { set; get; }

        public DateTime updated_date { set; get; }
        public int updated_by { set; get; }

        public virtual IEnumerable<AccountPermissionViewModel> AccountPermission { set; get; }

        public virtual IEnumerable<AccountProfileViewModel> AccountProfiles { set; get; }
    }
}