using Family_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Controllers
{
    public class ScarvesController : Controller
    {
        private family_storeContext context { get; set; }

        public ScarvesController(family_storeContext ctx)
        { context = ctx; }

        public IActionResult Index()
        {
            var clo = context.scarf.Include(e => e.Clothes).ToList();

            return View(clo);




        }

        public IActionResult search(string k)
        {
            var ba = context.scarf.Where(e => e.SCcolor.Contains(k)).ToList();

            return View("Index", ba);




        }
        public IActionResult Order()
        {
            var clo = context.scarf.Include(e => e.Clothes).OrderBy(e => e.SCprice).ToList();

            return View("Index",clo);




        }


    }
}

