using BookSale.Data.Infrastructure;
using BookSale.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IProduct_PriceRepository : IRepository<Product_Price>
    {
    }
    class Product_PriceRepository : RepositoryBase<Product_Price>, IProduct_PriceRepository
    {
        public Product_PriceRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
