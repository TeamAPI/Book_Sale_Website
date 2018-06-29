using BookSale.Data.Infrastructure;
using BookSale.Data.Repositories;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Service
{
    public interface IProductImagesService
    {
        void Add(ProductImages ProductImages);

        void Update(ProductImages ProductImages);

        void Delete(int id);

        Product GetById(int id);

        IEnumerable<Product> GetAllByTag(int page, int pagesize, out int totalrow);

        void SaveChange();
    }
    public class ProductImagesService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;

        public ProductImagesService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}
