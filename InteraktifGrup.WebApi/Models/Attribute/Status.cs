using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InteraktifGrup.WebApi.Models;
namespace InteraktifGrup.WebApi.Models.Attribute
{
    public class Status
    {
        public Enums.MessageCode code { get; set; }
        public string message { get; set; }
    }
}
