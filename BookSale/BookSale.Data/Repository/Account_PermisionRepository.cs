using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IAccount_permisionRepository : IRepository<Account_permission>
    {
    }
    public class Account_permisionRepository: RepositoryBase<Account_permission>, IAccount_permisionRepository
    {
        public Account_permisionRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
