using BookSale.Data.Infrastructure;
using BookSale.Model.Models;

namespace BookSale.Data.Repositories
{
    public interface IPermisionAccessRepository : IRepository<PermissionAccess>
    {
    }

    public class PermisionAccessRepository : RepositoryBase<PermissionAccess>, IPermisionAccessRepository
    {
        public PermisionAccessRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}