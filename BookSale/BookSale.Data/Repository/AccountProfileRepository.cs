using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IAccountProfileRepository : IRepository<AccountProfile>
    {
    }
    public class AccountProfileRepository : RepositoryBase<AccountProfile>, IAccountProfileRepository
    {
        public AccountProfileRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
