using InteraktifGrup.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteraktifGrup.Entity.Models
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public int Order{ get; set; }
    }
}
