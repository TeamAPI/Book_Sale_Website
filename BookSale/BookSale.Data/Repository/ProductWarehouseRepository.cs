using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IProductWarehouseRepository : IRepository<ProductWarehouse>
    {
    }
    public class ProductWarehouseRepository : RepositoryBase<ProductWarehouse>, IProductWarehouseRepository
    {
        public ProductWarehouseRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
