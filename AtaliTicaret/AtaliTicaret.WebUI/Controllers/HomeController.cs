using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AtaliTicaret.WebUI.Models;
using AtaliTicaret.Business.Abstract;

namespace AtaliTicaret.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IProductService _productServis;

        public HomeController(IProductService x)
        {
            _productServis = x;
        }

        public IActionResult Index()
        {
            return View(_productServis.GetEntities(null));
        }
    }
}
