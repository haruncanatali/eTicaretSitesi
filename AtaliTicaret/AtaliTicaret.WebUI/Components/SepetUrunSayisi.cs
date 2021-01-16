using AtaliTicaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtaliTicaret.WebUI.Components
{
    public class SepetUrunSayisi:ViewComponent
    {


        public IViewComponentResult Invoke()
        {

            int count = Sepet.ShowSumOfValues();

            return View(count);
        }
    }
}
