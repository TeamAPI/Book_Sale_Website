using BookSale.Data.Infrastructure;
using BookSale.Model.Models;

namespace BookSale.Data.Repositories
{
    public interface IPermision_accessRepository : IRepository<Permission_Access>
    {
    }

    public class Permision_accessRepository : RepositoryBase<Permission_Access>, IPermision_accessRepository
    {
        public Permision_accessRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}