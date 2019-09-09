using InteraktifGrup.DataAccess.Abstract;
using InteraktifGrup.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using InteraktifGrup.Entity.Context;
using System.Linq;

namespace InteraktifGrup.DataAccess.Congrete.EfRepository
{
    public class EfCategoryDal : ICategoryDal
    {
        InteraktifGrupContext context = new InteraktifGrupContext();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Category product)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            return context.Categories.Where(x => x.IsActive)
                .OrderBy(x => x.CategoryName)
                .ToList();
        }

        public Category Save(Category product)
        {
            throw new NotImplementedException();
        }

        public int Update(Category product)
        {
            throw new NotImplementedException();
        }
    }
}
