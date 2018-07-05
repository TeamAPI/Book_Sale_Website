using BookSale.Data.Infrastructure;
using BookSale.Data.Repository;
using BookSale.Model.Models;
using System.Collections.Generic;

namespace BookSale.Service
{
    public interface IProductImagesService
    {
        void Add(ProductImages productImages);

        void Update(ProductImages productImages);

        void Delete(int id);

        ProductImages GetById(int id);

        IEnumerable<ProductImages> GetAllByParentId(int parentId);
        IEnumerable<ProductImages> GetAll();

        void SaveChange();
    }

    public class ProductImagesService : IProductImagesService
    {
        private IProductImagesRepository _productImagesRepository;
        private IUnitOfWork _unitOfWork;

        public ProductImagesService(IProductImagesRepository productImagesRepository, IUnitOfWork unitOfWork)
        {
            this._productImagesRepository = productImagesRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(ProductImages productImage)
        {
            _productImagesRepository.Add(productImage);
        }

        public void Update(ProductImages productImage)
        {
            _productImagesRepository.Update(productImage);
        }

        public void Delete(int id)
        {
            _productImagesRepository.Delete(id);
        }

        public ProductImages GetById(int id)
        {
            return _productImagesRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public IEnumerable<ProductImages> GetAllByParentId(int parentId)
        {
            return _productImagesRepository.GetMulti(x => x.ProductID == parentId);
        }
      
        IEnumerable<ProductImages> IProductImagesService.GetAll()
        {
            return _productImagesRepository.GetAll();
        }

        ProductImages IProductImagesService.GetById(int id)
        {
            return _productImagesRepository.GetSingleById(id);
        }

    }
}