using InteraktifGrup.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteraktifGrup.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        Category Get(int id);
        List<Category> GetList();
        Category Save(Category product);
        int Update(Category product);
        bool Delete(int id);
        bool Delete(Category product);
    }
}
