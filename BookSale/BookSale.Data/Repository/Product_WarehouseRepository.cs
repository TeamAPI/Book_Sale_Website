using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IProduct_WarehouseRepository : IRepository<Product_Warehouse>
    {
    }
    public class Product_WarehouseRepository : RepositoryBase<Product_Warehouse>, IProduct_WarehouseRepository
    {
        public Product_WarehouseRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
