using Family_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Controllers
{
    public class BootController : Controller
    {
        private family_storeContext context { get; set; }

        public BootController(family_storeContext ctx)
        { context = ctx; }

        public IActionResult Index()
        {
            var clo = context.boot.Include(e => e.Clothes).OrderBy(e => e.BOprice).ToList();

            return View(clo);




        }

        public IActionResult search(string k)
        {
            var ba = context.boot.Where(e => e.BOcolor.Contains(k)).ToList();

            return View("Index", ba);




        }

    }
}
