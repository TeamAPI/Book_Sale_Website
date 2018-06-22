using BookSale.Data.Infrastructure;
using BookSale.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface ISupplyhouseRepository : IRepository<Supplyhouse>
    {
    }
    public class SupplyhouseRepository : RepositoryBase<Supplyhouse>, ISupplyhouseRepository
    {
        public SupplyhouseRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
