using BookSale.Data.Infrastructure;
using BookSale.Model.Models;

namespace BookSale.Data.Repository
{
    public interface IProductImagesRepository : IRepository<ProductImages>
    {
    }

    public class ProductImagesRepository : RepositoryBase<ProductImages>, IProductImagesRepository
    {
        public ProductImagesRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}