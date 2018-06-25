using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
    }
    public class ShoppingCartRepository : RepositoryBase<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
