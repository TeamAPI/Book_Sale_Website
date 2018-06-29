using BookSale.Data.Infrastructure;
using BookSale.Model.Models;

namespace BookSale.Data.Repositories
{
    public interface IAccountPermisionRepository : IRepository<AccountPermission>
    {
    }

    public class AccountPermisionRepository : RepositoryBase<AccountPermission>, IAccountPermisionRepository
    {
        public AccountPermisionRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}