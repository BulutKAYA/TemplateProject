using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteraktifGrup.WebApi.Models.Attribute
{
    public class Product
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
