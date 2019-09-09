using InteraktifGrup.Entity.Models;
using InteraktifGrup.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InteraktifGrup.Interfaces.ProductAtributes
{
    public interface IProductService:IGenericService<Product>
    {
        IQueryable<VProduct> GetListQueryAble();
    }
}
