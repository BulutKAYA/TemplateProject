using InteraktifGrup.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteraktifGrup.Entity.ViewModels
{
    public class VProduct
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int UnitInStock { get; set; }
        public decimal Price { get; set; }
        public decimal PriceVat { get; set; }
        public string CategoryName { get; set; }
    }
}
