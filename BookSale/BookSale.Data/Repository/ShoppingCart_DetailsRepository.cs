using BookSale.Data.Infrastructure;
using BookSale.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IShoppingCart_DetailsRepository : IRepository<ShoppingCart_Detail>
    {
    }
    public class ShoppingCart_DetailsRepository : RepositoryBase<ShoppingCart_Detail>, IShoppingCart_DetailsRepository
    {
        public ShoppingCart_DetailsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
