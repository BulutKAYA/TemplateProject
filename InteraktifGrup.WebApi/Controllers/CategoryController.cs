using System.Collections.Generic;
using InteraktifGrup.Business.BCategory;
using InteraktifGrup.DataAccess.Congrete.EfRepository;
using InteraktifGrup.Interfaces.ProductAtributes;
using InteraktifGrup.WebApi.Models.Attribute;
using Microsoft.AspNetCore.Mvc;

namespace InteraktifGrup.WebApi.Controllers
{
    [Route("api/category/")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService productService = new CategoryBll(new EfCategoryDal());

        [HttpPost]
        [Route("getlist")]
        public List<Entity.Models.Category> GetList([FromBody] Aut aut)
        {
            if (aut.userName == "bulut" || aut.password == "123")
            {
                return productService.GetList();
            }
            else
            {
                return null;
            }
        }
    }
}