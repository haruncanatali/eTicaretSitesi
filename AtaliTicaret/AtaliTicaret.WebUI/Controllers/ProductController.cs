using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtaliTicaret.Business.Abstract;
using AtaliTicaret.DataAccess.Concrete.EntityFramework;
using AtaliTicaret.Entites.Concrete;
using AtaliTicaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtaliTicaret.WebUI.Controllers
{
    public class ProductController : Controller
    {

        IProductService _productService;
        IDealerService _dealerService;

        public ProductController(IProductService x,IDealerService y)
        {
            _productService = x;
            _dealerService = y;


        }

        public IActionResult Index()
        {
            return Redirect("/Home/Index/");
        }

        public IActionResult Details(int id)
        {

            TempData["url"] = "/Product/Details/"+id.ToString()+"/";

            Product entity = _productService.GetEntity(c => c.ProductId == id);
            entity.Dealer = _dealerService.GetEntity(c => c.DealerId == entity.DealerId);

            return View(entity);
        }

        public IActionResult CategoryProductsList(int id)
        {
            return View(_productService.GetEntities(c => c.CategoryId == id));
        }

        public IActionResult WantedKey(string key)
        {
            return View("CategoryProductsList",_productService.GetEntities(c => c.ProductName.Contains(key)));
        }
    }
}
