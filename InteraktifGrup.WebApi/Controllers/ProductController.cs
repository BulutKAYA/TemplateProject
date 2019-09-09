using Microsoft.AspNetCore.Mvc;
using InteraktifGrup.Interfaces.ProductAtributes;
using InteraktifGrup.Business.BProduct;
using InteraktifGrup.DataAccess.Congrete.EfRepository;
using InteraktifGrup.WebApi.Models.Response;
using InteraktifGrup.WebApi.Models.Attribute;
using InteraktifGrup.WebApi.Models;
using InteraktifGrup.WebApi.Models.Request;
using System;

namespace InteraktifGrup.WebApi.Controllers
{
    [Route("api/product/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService productService = new ProductBll(new EfProductDal());

        [HttpPost]
        [Route("getlist")]
        public ProductListResponse GetList([FromBody] Aut aut)
        {
            if(aut.userName != "bulut" || aut.password != "123"){
                return new ProductListResponse
                {
                    status = new Status()
                    {
                        code = Enums.MessageCode.Basarisiz,
                        message = "Erişim Engellendi!"
                    },
                    productList = null
                };
            }
            else {
                return new ProductListResponse
                {
                    status = new Status()
                    {
                        code = Enums.MessageCode.Basarili,
                        message = "Başarılı!"
                    },
                    productList = productService.GetListQueryAble()
                };
            }
        }

        //bu metod doldurulmadı yukarıdaki mantığa benzer bişeyler yapılabilinir
        [HttpGet("{id}")]
        [Route("get")]
        public string Get()
        {
            return "value";
        }

        [HttpPost]
        [Route("add")]
        public ProductResponse Add([FromBody] ProductRequest productRequest)
        {
            if (productRequest.aut.userName != "bulut" || productRequest.aut.password != "123")
            {
                return new ProductResponse
                {
                    status = new Status()
                    {
                        code = Enums.MessageCode.Basarisiz,
                        message = "Erişim Engellendi!"
                    }
                };
            }
            else
            {
                try
                {
                    productService.Save(new Entity.Models.Product
                    {
                        CategoryId = productRequest.product.CategoryId,
                        ProductName = productRequest.product.ProductName,
                        Price = productRequest.product.Price,
                        PriceVat = productRequest.product.PriceVat
                    });
                    return new ProductResponse
                    {
                        status = new Status()
                        {
                            code = Enums.MessageCode.Basarili,
                            message = "Başarılı!"
                        }
                    };
                }
                catch(Exception e)
                {
                    return new ProductResponse
                    {
                        status = new Status()
                        {
                            code = Enums.MessageCode.Basarisiz,
                            message = e.Message
                        }
                    };
                }
               
            }
        }

        [HttpPost]
        [Route("update")]
        public ProductResponse Update([FromBody] ProductRequest productRequest)
        {
            if (productRequest.aut.userName != "bulut" || productRequest.aut.password != "123")
            {
                return new ProductResponse
                {
                    status = new Status()
                    {
                        code = Enums.MessageCode.Basarisiz,
                        message = "Erişim Engellendi!"
                    }
                };
            }
            else
            {
                try
                {
                    productService.Update(new Entity.Models.Product
                    {
                        CategoryId = productRequest.product.CategoryId,
                        ProductName = productRequest.product.ProductName,
                        Price = productRequest.product.Price,
                        PriceVat = productRequest.product.PriceVat
                    });

                    return new ProductResponse
                    {
                        status = new Status()
                        {
                            code = Enums.MessageCode.Basarili,
                            message = "Başarılı!"
                        }
                    };
                }
                catch (Exception e)
                {
                    return new ProductResponse
                    {
                        status = new Status()
                        {
                            code = Enums.MessageCode.Basarisiz,
                            message = e.Message
                        }
                    };
                }
            }
        }
        [HttpPost]
        [Route("delete")]
        public ProductResponse Delete([FromBody] ProductRequest productRequest)
        {
            if (productRequest.aut.userName != "bulut" || productRequest.aut.password != "123")
            {
                return new ProductResponse
                {
                    status = new Status()
                    {
                        code = Enums.MessageCode.Basarisiz,
                        message = "Erişim Engellendi!"
                    }
                };
            }
            else
            {
                try
                {
                    productService.Delete(new Entity.Models.Product
                    {
                        CategoryId = productRequest.product.CategoryId,
                        ProductName = productRequest.product.ProductName,
                        Price = productRequest.product.Price,
                        PriceVat = productRequest.product.PriceVat
                    });

                    return new ProductResponse
                    {
                        status = new Status()
                        {
                            code = Enums.MessageCode.Basarili,
                            message = "Başarılı!"
                        }
                    };
                }
                catch (Exception e)
                {
                    return new ProductResponse
                    {
                        status = new Status()
                        {
                            code = Enums.MessageCode.Basarisiz,
                            message = e.Message
                        }
                    };
                }
            }
        }
    }
}
