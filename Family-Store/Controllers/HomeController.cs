using Family_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Controllers
{
    public class HomeController : Controller
    {
       private family_storeContext context { get; set; }

        public HomeController (family_storeContext ctx)
        { context = ctx; }


        public IActionResult Index()
        {
            return View();



        }





        /*  public IActionResult Detail(string ctype)
           {
               Clothes product = DB.GetProduct(ctype);
               return View(product);
           }

           public IActionResult List()
           {
               List<Clothes> products = DB.GetProducts();
               return View(products);
           }

   */

    }
}
