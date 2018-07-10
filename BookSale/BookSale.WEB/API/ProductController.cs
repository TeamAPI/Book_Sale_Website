using AutoMapper;
using BookSale.Model.Models;
using BookSale.Service;
using BookSale.Web.Infrastructure.Core;
using BookSale.WEB.Infratructure.Core;
using BookSale.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookSale.WEB.API
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiControllerBase
    {
        #region Initialize

        private IProductService _productService;

        public ProductController(IErrorService errorService, IProductService productService)
            : base(errorService)
        {
            this._productService = productService;
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
                var query = listProduct.Skip((page-1) * pagesize).Take(pagesize);
                var listProductVm = Mapper.Map<List<ProductViewModel>>(query);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listProductVm);
                return response;
            });
        }

        //lấy ra danh sách sản phẩm lọc theo status là " Đang hoạt động " và phân trang cho danh sách
        [Route("getallwhithstate")]
        [HttpGet]
        public HttpResponseMessage getallpaging1(HttpRequestMessage request, int page, int pagesize = 2)
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

    }
}