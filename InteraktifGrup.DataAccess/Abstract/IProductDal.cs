using System;
using System.Collections.Generic;
using System.Text;
using InteraktifGrup.Entity.Models;
using InteraktifGrup.Entity.ViewModels;
using System.Linq;

namespace InteraktifGrup.DataAccess.Abstract
{
    public interface IProductDal
    {
        Product Get(int id);
        IQueryable<VProduct> GetList();
        Product Save(Product product);
        int Update(Product product);
        bool Delete(int id);
        bool Delete(Product product);

    }
}
