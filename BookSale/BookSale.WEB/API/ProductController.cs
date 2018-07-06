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
        #endregion
        [Route("getall")]
        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listProduct = _productService.Getall();

                var listProductVm = Mapper.Map<List<ProductViewModel>>(listProduct);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listProductVm);

                return response;
            });
        }
    }
}