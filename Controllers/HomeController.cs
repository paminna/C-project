using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNurgalieva.Models;
namespace WebNurgalieva.Controllers
{
    public class HomeController : Controller
    {
        DogContext dogContext = new DogContext();
        public ActionResult Index()
        {
            IEnumerable<Dog> dogs = dogContext.Dogs;
            ViewBag.Dogs = dogs;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.DateTime = GetTodayDate();
            dogContext.Purchases.Add(purchase);
            dogContext.SaveChanges();
            return $"Уважаемый, {purchase.FIO}, с вами скоро свяжутся!";
        }
        private DateTime GetTodayDate()
        {
            return DateTime.Now;
        }
          
    }
}