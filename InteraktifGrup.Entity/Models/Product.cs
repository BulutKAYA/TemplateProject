using InteraktifGrup.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteraktifGrup.Entity.Models
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int UnitInStock { get; set; }
        public decimal Price { get; set; }
        public decimal PriceVat { get; set; }
        
    }
}
