using Family_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Controllers
{
   
    
        public class ShoesController : Controller
        {


            private family_storeContext context { get; set; }

            public ShoesController(family_storeContext ctx)
            { context = ctx; }

            public IActionResult Index()
            {
                var clo = context.shoes.Include(e => e.Clothes).ToList();

                return View(clo);




            }

            public IActionResult search(string k)
            {
                var ba = context.shoes.Where(e => e.SHcolor.Contains(k)).ToList();

                return View("Index", ba);




            }
            [HttpGet]
            public IActionResult Order()
            {
                var clo = context.shoes.OrderBy(e => e.SHprice).ToList();

                return View("Index", clo);




            }

            [HttpGet]
            public IActionResult Register()
            {

                return View(new Shoes());
            }


            [HttpPost]
            public IActionResult Register(Shoes B)
            {
                if (ModelState.IsValid)
                {
                    context.shoes.Add(B);
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
                var ba = context.shoes.Find(id);
                return View(ba);
            }

            [HttpPost]
            public IActionResult Delete(Shoes b)
            {
                context.shoes.Remove(b);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }

