using InteraktifGrup.WebApi.Models.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteraktifGrup.WebApi.Models.Request
{
    public class CategoryRequest
    {
        public Aut aut { get; set; }
        public Category category { get; set; }
    }
}
