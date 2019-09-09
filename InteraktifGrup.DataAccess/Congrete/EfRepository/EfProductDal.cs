using InteraktifGrup.DataAccess.Abstract;
using InteraktifGrup.Entity.Context;
using InteraktifGrup.Entity.Models;
using InteraktifGrup.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InteraktifGrup.DataAccess.Congrete.EfRepository
{
    public class EfProductDal : IProductDal
    {
        InteraktifGrupContext context = new InteraktifGrupContext();

        public bool Delete(int id)
        {
            Product product = Get(id);
            context.Products.Remove(product);
            return context.SaveChanges() > 0;
        }

        public bool Delete(Product product)
        {
            context.Products.Remove(product);
            return context.SaveChanges() > 0;
        }

        public Product Get(int id)
        {
            return context.Products.Find(id);
        }

        public IQueryable<VProduct> GetList()
        {
            return (from a in context.Products
                          join b in context.Categories on a.CategoryId equals b.CategoryId
                          select new VProduct
                          {
                              ProductId = a.ProductId,
                              CategoryId = a.CategoryId,
                              CategoryName = b.CategoryName,
                              ProductName = a.ProductName,
                              UnitInStock = a.UnitInStock,
                              Price = a.Price,
                              PriceVat = a.PriceVat
                          }).AsQueryable();
        }

        public Product Save(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }

        public int Update(Product product)
        {
            context.Update(product);
            return context.SaveChanges();
        }
    }
}
