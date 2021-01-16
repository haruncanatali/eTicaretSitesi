using AtaliTicaret.Business.Abstract;
using AtaliTicaret.Entites.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtaliTicaret.WebUI.Components
{
    public class CategoriesSum:ViewComponent
    {
        ICategoryService _categoryService;
        IProductService _productService;

        public CategoriesSum(ICategoryService wx,IProductService x)
        {
            _categoryService = wx;
            _productService = x;
        }

        public IViewComponentResult Invoke()
        {

            List<Category> entities = _categoryService.GetEntities(null);
            List<Product> entitiesp = _productService.GetEntities(null);

            for (int i = 0; i < entities.Count(); i++)
            {
                for (int j = 0; j < entitiesp.Count(); j++)
                {
                    if(entitiesp[j].CategoryId == entities[i].CategoryId)
                    {
                        entities[i].Products.Add(entitiesp[j]);
                    }
                }
            }

            return View(entities);
        }
    }
}
