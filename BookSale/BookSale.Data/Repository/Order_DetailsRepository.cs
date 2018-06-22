using BookSale.Data.Infrastructure;
using BookSale.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IOrder_DetailsRepository : IRepository<Order_Detail>
    {
    }
    public class Order_DetailsRepository : RepositoryBase<Order_Detail>, IOrder_DetailsRepository
    {
        public Order_DetailsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
