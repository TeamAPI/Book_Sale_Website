using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IPromotion_ProductRepository : IRepository<Promotion_Product>
    {
    }
    public class Promotion_ProductRepository : RepositoryBase<Promotion_Product>, IPromotion_ProductRepository
    {
        public Promotion_ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
