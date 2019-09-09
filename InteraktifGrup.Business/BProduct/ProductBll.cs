using InteraktifGrup.DataAccess.Abstract;
using InteraktifGrup.Entity.Models;
using InteraktifGrup.Entity.ViewModels;
using InteraktifGrup.Interfaces.ProductAtributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InteraktifGrup.Business.BProduct
{
    public class ProductBll : IProductService
    {
        IProductDal productDal;
        public ProductBll(IProductDal _productDal)
        {
            this.productDal = _productDal;
        }
        public bool Delete(int id)
        {
            return productDal.Delete(id);
        }
        public bool Delete(Product product)
        {
            return productDal.Delete(product);
        }
        public Product Get(int id)
        {
            return productDal.Get(id);
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
        public IQueryable<VProduct> GetListQueryAble()
        {
            return productDal.GetList();
        }
        public Product Save(Product product)
        {
            return productDal.Save(product);
        }

        public int Update(Product product)
        {
            return productDal.Update(product);
        }
    }
}
