using BookSale.Data.Infrastructure;
using BookSale.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IAccount_PermisionRepository : IRepository<Account_Permission>
    {
    }
    public class Account_PermisionRepository: RepositoryBase<Account_Permission>, IAccount_PermisionRepository
    {
        public Account_PermisionRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
