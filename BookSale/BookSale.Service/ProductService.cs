using BookSale.Data.Infrastructure;
using BookSale.Data.Repositories;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;

namespace BookSale.Service
{
    public interface IProductService
    {
        void Add(Product product);

        void Update(Product product);

        void Delete(int id);

        IEnumerable<Product> Getall();

        IEnumerable<Product> GetAllPaging(int page, int pagesize, out int totalrow);

        Product GetById(int id);

        IEnumerable<Product> GetAllByTag(int page, int pagesize, out int totalrow);

        void SaveChange();
    }

    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> Getall()
        {
            return _productRepository.GetAll(new string[] { "Product_Price" });
        }

        public IEnumerable<Product> GetAllByTag(int page, int pagesize, out int totalrow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllPaging(int page, int pagesize, out int totalrow)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}