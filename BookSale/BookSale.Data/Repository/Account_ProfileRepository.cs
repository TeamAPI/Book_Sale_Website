using BookSale.Data.Infrastructure;
using BookSale.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IAccount_ProfileRepository : IRepository<Account_Profile>
    {
    }
    public class Account_ProfileRepository : RepositoryBase<Account_Profile>, IAccount_ProfileRepository
    {
        public Account_ProfileRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
