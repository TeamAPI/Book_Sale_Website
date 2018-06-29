using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IShoppingCartDetailsRepository : IRepository<ShoppingCartDetail>
    {
    }
    public class ShoppingCartDetailsRepository : RepositoryBase<ShoppingCartDetail>, IShoppingCartDetailsRepository
    {
        public ShoppingCartDetailsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
