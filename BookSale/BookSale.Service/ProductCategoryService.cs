using BookSale.Data.Infrastructure;
using BookSale.Data.Repository;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Service
{
    public class ProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._productCategoryRepository = productCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<ProductCategory> Getall()
        {
            return _productCategoryRepository.GetAll();
        }
        public ProductCategory GetById(int id)
        {
            return _productCategoryRepository.GetSingleById(id);
        }

    }
}
