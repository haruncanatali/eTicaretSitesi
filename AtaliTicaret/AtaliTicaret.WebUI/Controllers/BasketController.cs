using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtaliTicaret.Business.Abstract;
using AtaliTicaret.Entites.Concrete;
using AtaliTicaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtaliTicaret.WebUI.Controllers
{
    public class BasketController : Controller
    {
        IProductService _productService;

        public BasketController(IProductService x)
        {
            _productService = x;
        }

        public IActionResult Index()
        {

            List<int> keys = Sepet.Ids.Keys.ToList();

            var entity = _productService.GetProductsFromInTheBasket(keys);

            return View(entity);
        }

        public IActionResult AddProductForBasket(int ProductId,string reUrl)
        {

            Sepet.AddId(ProductId);

            return Redirect(reUrl);
        }

        public IActionResult ClearBasket()
        {
            Sepet.Ids.Clear();

            return RedirectToAction("Index");
        }

        public IActionResult IncreaseProduct(int id)
        {

            if (Sepet.Ids.ContainsKey(id))
            {
                Sepet.Ids[id] += 1;
            }

            return RedirectToAction("Index");
        }

        public IActionResult DecreaseProduct(int id)
        {
            if (Sepet.Ids.ContainsKey(id))
            {
                Sepet.Ids[id] -= 1;

                if(Sepet.Ids[id] == 0)
                {
                    Sepet.Ids.Remove(id);
                }
            }

            return RedirectToAction("Index");
        }



    }
}
