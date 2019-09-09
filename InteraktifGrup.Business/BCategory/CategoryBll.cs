using InteraktifGrup.DataAccess.Abstract;
using InteraktifGrup.Entity.Models;
using InteraktifGrup.Interfaces.ProductAtributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteraktifGrup.Business.BCategory
{
    public class CategoryBll : ICategoryService
    {
        public ICategoryDal categoryDal;
        public CategoryBll(ICategoryDal _categoryDal)
        {
            categoryDal = _categoryDal;
        }
        public bool Delete(int id)
        {
            return categoryDal.Delete(id);
        }

        public bool Delete(Category category)
        {
            return categoryDal.Delete(category);
        }

        public Category Get(int id)
        {
            return categoryDal.Get(id);
        }

        public List<Category> GetList()
        {
            return categoryDal.GetList();
        }

        public Category Save(Category category)
        {
            return categoryDal.Save(category);
        }

        public int Update(Category category)
        {
            return categoryDal.Update(category);
        }
    }
}
