using Family_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Controllers
{
    public class GirlsController : Controller
    {

        private family_storeContext context { get; set; }

        public GirlsController(family_storeContext ctx)
        { context = ctx; }

        public IActionResult Index()
        {


            return RedirectToAction("Index", "Jaket");


        }
        public IActionResult Index1()
        {


            return RedirectToAction("Index", "Home");


        }
    }
}
