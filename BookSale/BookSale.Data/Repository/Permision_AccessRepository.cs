using BookSale.Data.Infrastructure;
using BookSale.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IPermision_AccessRepository : IRepository<Permission_Access>
    {
    }
    public class Permision_AccessRepository : RepositoryBase<Permission_Access>, IPermision_AccessRepository
    {
        public Permision_AccessRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
