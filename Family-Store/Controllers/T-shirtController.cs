using Family_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Controllers
{
    public class T_shirtController : Controller
    {


        private family_storeContext context { get; set; }

        public T_shirtController(family_storeContext ctx)
        { context = ctx; }

        public IActionResult Index()
        {
            var clo = context.t_shirts.Include(e => e.Clothes).ToList();

            return View(clo);




        }

        public IActionResult search(string k)
        {
            var ba = context.t_shirts.Where(e => e.STcolor.Contains(k)).ToList();

            return View("Index", ba);




        }
        [HttpGet]
        public IActionResult Order()
        {
            var clo = context.t_shirts.OrderBy(e => e.STprice).ToList();

            return View("Index", clo);




        }

        [HttpGet]
        public IActionResult Register()
        {

            return View(new T_shirts());
        }


        [HttpPost]
        public IActionResult Register(T_shirts B)
        {
            if (ModelState.IsValid)
            {
                context.t_shirts.Add(B);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {

                return View(B);
            }
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            var ba = context.t_shirts.Find(id);
            return View(ba);
        }

        [HttpPost]
        public IActionResult Delete(T_shirts b)
        {
            context.t_shirts.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
