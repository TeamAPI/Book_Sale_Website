using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IAccountRepository : IRepository<Account>
    {
    }
   public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
