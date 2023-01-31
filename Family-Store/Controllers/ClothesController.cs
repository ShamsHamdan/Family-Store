using Family_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Controllers
{
    public class ClothesController : Controller



    {

        private family_storeContext context { get; set; }

        public ClothesController(family_storeContext ctx)
        { context = ctx; }
        public IActionResult Index()
        {
            var c = context.clothes.Include(e => e.family).ToList();

            return View(c);




        }
    }
}
