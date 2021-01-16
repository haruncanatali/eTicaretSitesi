using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtaliTicaret.Business.Abstract;
using AtaliTicaret.Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AtaliTicaret.WebUI.Controllers
{
    public class DealerController : Controller
    {
        IDealerService _dealerService;
        IProductService _productService;

        public DealerController(IDealerService x,IProductService y)
        {
            _dealerService = x;
            _productService = y;
        }
        public IActionResult Index()
        {
            return View(_dealerService.GetEntities(null));
        }
        public IActionResult Details(int id)
        {

            Dealer entity = _dealerService.GetEntity(c => c.DealerId == id);
            entity.Products = _productService.GetEntities(c => c.DealerId == id);

            return View(entity);
        }
    }
}
