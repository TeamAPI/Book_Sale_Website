using BookSale.Data.Infrastructure;
using BookSale.Model.Models;

namespace BookSale.Data.Repositories
{
    public interface IAccount_permisionRepository : IRepository<Account_Permission>
    {
    }

    public class Account_permisionRepository : RepositoryBase<Account_Permission>, IAccount_permisionRepository
    {
        public Account_permisionRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}