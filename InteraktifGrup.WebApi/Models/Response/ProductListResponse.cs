using InteraktifGrup.Entity.ViewModels;
using InteraktifGrup.WebApi.Models.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteraktifGrup.WebApi.Models.Response
{
    public class ProductListResponse
    {
        public Status status { get; set; }
        public IQueryable<VProduct> productList { get; set; }
    }
}
