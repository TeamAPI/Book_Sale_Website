using AutoMapper;
using BookSale.Model.Models;
using BookSale.Service;
using BookSale.Web.Infrastructure.Core;
using BookSale.WEB.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace BookSale.WEB.API
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiControllerBase
    {
        #region Initialize

        private IProductService _productService;
        private IProductImagesService _productImagesService;
        public ProductController(IErrorService errorService, IProductService productService, IProductImagesService productImagesService)
            : base(errorService)
        {
            this._productService = productService;
            this._productImagesService = productImagesService;
        }

        #endregion Initialize

        //lấy ra danh sách tất cả sản phẩm và phân trang cho danh sách
        [Route("getall")]
        [HttpGet]
        public HttpResponseMessage Getallforthefirstpage(HttpRequestMessage request, int page, int pagesize = 2)
        {
            return CreateHttpResponse(request, () =>
            {
                var listProduct = _productService.Getall();
                foreach(var item in listProduct)
                {
                    item.ProductImages = _productImagesService.GetAllByParentId(item.ProductID);
                }
                var query = listProduct.Skip((page-1) * pagesize).Take(pagesize);
                var listProductVm = Mapper.Map<List<ProductViewModel>>(query);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listProductVm);
                return response;
            });
        }

        //lấy ra danh sách sản phẩm lọc theo status là " Đang hoạt động " và phân trang cho danh sách
        [Route("getallwhithstate")]
        [HttpGet]
        public HttpResponseMessage getallpaging(HttpRequestMessage request, int page, int pagesize = 2)
        {
            return CreateHttpResponse(request, () =>
            {
                int totalrow = 0;
                var listProduct = _productService.GetAllPaging(page,pagesize,out totalrow);
                var listProductVm = Mapper.Map<List<ProductViewModel>>(listProduct);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listProductVm);
                return response;
            });
        }

        //lấy ra danh sách sản phẩm lọc theo status là " Đang hoạt động " và phân trang cho danh sách
        [Route("getsearch")]
        [HttpGet]
        public HttpResponseMessage getsearch(HttpRequestMessage request,string keyword)
        {
            return CreateHttpResponse(request, () =>
            {
                var listProduct = _productService.GetListProduct(keyword);
                int totalrow = listProduct.Count();
                //if ((totalrow/20) !=0)
                var listProductVm = Mapper.Map<List<ProductViewModel>>(listProduct);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listProductVm);
                return response;
            });
        }

        [Route("delete")]
        [HttpDelete]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var oldProductCategory = _productService.Delete(id);
                    _productService.SaveChange();

                    var responseData = Mapper.Map<Product, ProductViewModel>(oldProductCategory);
                    response = request.CreateResponse(HttpStatusCode.Created, responseData);
                }

                return response;
            });
        }
        [Route("deletemulti")]
        [HttpDelete]
        public HttpResponseMessage DeleteMulti(HttpRequestMessage request, string checkedProducts)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listProductCategory = new JavaScriptSerializer().Deserialize<List<int>>(checkedProducts);
                    foreach (var item in listProductCategory)
                    {
                        _productService.Delete(item);
                    }

                    _productService.SaveChange();

                    response = request.CreateResponse(HttpStatusCode.OK, listProductCategory.Count);
                }

                return response;
            });
        }

    }
}