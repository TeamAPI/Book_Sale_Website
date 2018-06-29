using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IProductPriceRepository : IRepository<ProductPrice>
    {
    }
    class ProductPriceRepository : RepositoryBase<ProductPrice>, IProductPriceRepository
    {
        public ProductPriceRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
