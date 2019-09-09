using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InteraktifGrup.UI.Models;
using InteraktifGrup.Entity.ViewModels;
using System.Net.Http;

namespace InteraktifGrup.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }
    }
}
