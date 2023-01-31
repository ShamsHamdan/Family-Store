using Family_Store.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Controllers
{
    public class BagController : Controller
    {


        private family_storeContext context { get; set; }

        public BagController(family_storeContext ctx)
        { context = ctx; }

        public IActionResult Index()
        {
            var clo = context.bag.Include(e => e.Clothes).ToList();

            return View(clo);




        }

        public IActionResult search(string k)
        {
            var ba = context.bag.Where(e => e.Bcolor.Contains(k)).ToList();

            return View("Index", ba);




        }
        [HttpGet]
        public IActionResult Order()
        {
            var clo = context.bag.OrderBy(e => e.Bprice).ToList();

            return View("Index", clo);




        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new Logincs());
        }

        [HttpPost]
        public IActionResult Login(Logincs data)
        {
            if (data.id == "6" && data.pass == "6")
            {
                HttpContext.Session.SetString("id", data.id);
                HttpContext.Session.SetString("pass", data.pass);
                return View("Register");
            }
            else { return View(data); }
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (HttpContext.Session.GetString("id")!=null)
            { return View(new Bags()); }
            else { return View("Login"); }


        }


        [HttpPost]
        public IActionResult Register(Bags B)
        {


            context.bag.Add(B);
            context.SaveChanges();
            return RedirectToAction("Index");
        }




        [HttpGet]
        public IActionResult Delete(int id)
        {
            var ba = context.bag.Find(id);
            return View(ba);
        }

        [HttpPost]
        public IActionResult Delete(Bags b)
        {
            context.bag.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}



