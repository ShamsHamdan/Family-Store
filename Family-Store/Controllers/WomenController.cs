using Family_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Controllers
{
    public class WomenController : Controller
    {

        private family_storeContext context { get; set; }

        public WomenController(family_storeContext ctx)
        { context = ctx; }

        public IActionResult Index()
        {


            return RedirectToAction("Index","Bag");


        }
        public IActionResult Index1()
        {


            return RedirectToAction("Index", "Home");


        }
    }
}
