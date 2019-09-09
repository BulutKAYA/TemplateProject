using InteraktifGrup.WebApi.Models.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteraktifGrup.WebApi.Models.Request
{
    public class ProductRequest
    {
        public Aut aut { get; set; }
        public RQProduct product { get; set; }
    }
    public class RQProduct
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal PriceVat { get; set; }
    }
}
