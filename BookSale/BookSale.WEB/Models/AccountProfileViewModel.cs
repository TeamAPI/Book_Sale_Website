using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class AccountProfileViewModel
    {
       
        public int AccountProfileID { set; get; }

       
        public string AccountProfileUsername { set; get; }

        public Boolean AccountProfileSex { set; get; }

        public DateTime AccountProfileDateofbirth { set; get; }

        
        public string AccountProfileEmail { set; get; }

        public string AccountProfileAddress { set; get; }

     
    
        public string AccountProfileNumberphone { set; get; }


        public string AcountProfileImages { set; get; }

        public int AccountID { set; get; }

        public virtual AccountViewModel Accounts { set; get; }
    }
}