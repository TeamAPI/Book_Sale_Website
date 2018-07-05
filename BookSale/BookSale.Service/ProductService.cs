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
        IEnumerable<Product> Getall(string keyword);
        IEnumerable<Product> GetAllPaging(int page, int pagesize, out int totalrow);
        Product GetById(int id);
        IEnumerable<Product> GetListProduct(string keyword);
        bool SellProduct(int productId, int quantity);

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
        public IEnumerable<Product> Getall(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _productRepository.GetMulti(x => x.ProductName.Contains(keyword) || x.Description.Contains(keyword));
            else
                return _productRepository.GetAll();
        }

        public IEnumerable<Product> GetAllPaging(int page, int pagesize, out int totalrow)
        {
            return _productRepository.GetMultiPaging(x=>x.ProductStatus =="Đang hoạt động" ,out totalrow, page, pagesize);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product Product)
        {
            _productRepository.Update(Product);
        }

        //Selling product
        public bool SellProduct(int productId, int quantity)
        {
            var product = _productRepository.GetSingleById(productId);
            if (product.Quantity < quantity)
                return false;
            product.Quantity -= quantity;
            return true;
        }

        public IEnumerable<Product> GetListProduct(string keyword)
        {
            IEnumerable<Product> query;
            if (!string.IsNullOrEmpty(keyword))
                query = _productRepository.GetMulti(x => x.ProductName.Contains(keyword));
            else
                query = _productRepository.GetAll();
            return query;
        }









    }
}