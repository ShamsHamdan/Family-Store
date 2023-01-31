using Family_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Controllers
{
    public class DressController : Controller
    {

        private family_storeContext context { get; set; }

        public DressController(family_storeContext ctx)
        { context = ctx; }

        public IActionResult Index()
        {
            var d = context.dress.Include(e => e.clothes).OrderBy(e => e.Dprice).ToList();

            return View(d);




        }
    }
}
