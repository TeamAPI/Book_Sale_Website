using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repository
{
    public interface IPromotionImagesRepository : IRepository<PromotionImages>
    {
    }

    public class PromotionImagesRepository : RepositoryBase<PromotionImages>, IPromotionImagesRepository
    {
        public PromotionImagesRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
