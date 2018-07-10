using BookSale.Data.Infrastructure;
using BookSale.Data.Repositories;
using BookSale.Model.Models;
using System.Collections.Generic;
using System.Linq;
using System;

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

        IEnumerable<Product> GetAllByProductCategory(int productCategory, int page, int pagesize, out int totalrow);

        IEnumerable<Product> GetAllBySuppluhouse(int supplyHouse, int page, int pagesize, out int totalrow);

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
            //var product = _productRepository.Add(Product);
            //_unitOfWork.Commit();
            //if (!string.IsNullOrEmpty(Product.Tags))
            //{
            //    string[] tags = Product.Tags.Split(',');
            //    for (var i = 0; i < tags.Length; i++)
            //    {
            //        var tagId = StringHelper.ToUnsignString(tags[i]);
            //        if (_tagRepository.Count(x => x.ID == tagId) == 0)
            //        {
            //            Tag tag = new Tag();
            //            tag.ID = tagId;
            //            tag.Name = tags[i];
            //            tag.Type = CommonConstants.ProductTag;
            //            _tagRepository.Add(tag);
            //        }

            //        ProductTag productTag = new ProductTag();
            //        productTag.ProductID = Product.ID;
            //        productTag.TagID = tagId;
            //        _productTagRepository.Add(productTag);
            //        //    }
            //    }
            }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> Getall()
        {
            return _productRepository.GetAll(new string[] {"ProductCategory", "Supplyhouses",});
        }

        public IEnumerable<Product> GetAllByProductCategory(int productCategory, int page, int pagesize, out int totalrow)
        {
            var query = _productRepository.GetMulti(x => x.ProductStatus == "Đang hoạt động" && x.ProductCategoryID == productCategory);
            totalrow = query.Count();
            return query.Skip((page - 1) * pagesize).Take(pagesize);
        }

        public IEnumerable<Product> GetAllBySuppluhouse(int supplyHouse, int page, int pagesize, out int totalrow)
        {
            var query = _productRepository.GetMulti(x => x.ProductStatus == "Đang hoạt động" && x.SupplyhouseID == supplyHouse);
            totalrow = query.Count();
            return query.Skip((page - 1) * pagesize).Take(pagesize);
        }

        public IEnumerable<Product> GetAllPaging(int page, int pagesize, out int totalrow)
        {
            var query = _productRepository.GetMulti(x => x.ProductStatus == "Đang hoạt động");
            totalrow = query.Count();
            return query.Skip((page - 1) * pagesize).Take(pagesize);
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

        // serch with product name
        public IEnumerable<Product> GetListProduct(string keyword)
        {
            IEnumerable<Product> query;
            if (!string.IsNullOrEmpty(keyword))
                query = _productRepository.GetMulti(x => x.ProductStatus == "Đang hoạt động" &&( x.ProductName.Contains(keyword) || x.Author.Contains(keyword) || x.Description.Contains(keyword) || x.Stralator.Contains(keyword) || x.Publishinghouse.Contains(keyword)) , new string[] { "ProductCategory", "Supplyhouses" });
            else
                query = _productRepository.GetMulti(x => x.ProductStatus == "Đang hoạt động" , new string[] { "ProductCategory", "Supplyhouses" });
            return query;
        }



    }
}