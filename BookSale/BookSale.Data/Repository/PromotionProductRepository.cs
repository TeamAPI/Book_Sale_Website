using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IPromotionProductRepository : IRepository<PromotionProduct>
    {
    }
    public class PromotionProductRepository : RepositoryBase<PromotionProduct>, IPromotionProductRepository
    {
        public PromotionProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
