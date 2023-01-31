using Family_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Controllers
{
    
    
        public class JaketController : Controller
        {


            private family_storeContext context { get; set; }

            public JaketController(family_storeContext ctx)
            { context = ctx; }

            public IActionResult Index()
            {
                var clo = context.jaket.Include(e => e.Clothes).ToList();

                return View(clo);




            }

            public IActionResult search(string k)
            {
                var ba = context.jaket.Where(e => e.Jcolor.Contains(k)).ToList();

                return View("Index", ba);




            }
            [HttpGet]
            public IActionResult Order()
            {
                var clo = context.jaket.OrderBy(e => e.Jprice).ToList();

                return View("Index", clo);




            }

            [HttpGet]
            public IActionResult Register()
            {

                return View(new Jakets());
            }


            [HttpPost]
            public IActionResult Register(Jakets B)
            {
                if (ModelState.IsValid)
                {
                    context.jaket.Add(B);
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
                var ba = context.jaket.Find(id);
                return View(ba);
            }

            [HttpPost]
            public IActionResult Delete(Jakets b)
            {
                context.jaket.Remove(b);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }

